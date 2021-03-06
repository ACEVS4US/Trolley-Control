﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Trolley_Control
{
    class AgilentBridge:ResistanceBridge
    {
        
        //protected const double F26Corr = 1.000044;
        AgilentMUX agilent_bridge_mux;

        /// <summary>
        /// Creates a new Agilent Bridge
        /// </summary>
        /// <param name="address">The GPIB Address of the Bridge/MUX</param>
        /// <param name="gatewaystring">The SICL interface ID of the gateway</param>
        /// <param name="multi">The multiplexor associated with this device.  Each bridge create must have a multiplexor object even if it is integral to the bridge</param>
        public AgilentBridge(short address, string gatewaystring,ref MUX multi):base(address,gatewaystring,ref multi)
        {
            agilent_bridge_mux = (AgilentMUX) multi;
            string init_string = String.Concat(SICL_interface_id, Convert.ToString(GPIB_adr));
            InitIO(init_string);
        }
        
        /// <summary>
        /// -Current must be between 0 and 3 which equates to 0.1mA, 0.3mA, 1mA and 3mA.
        /// </summary>
        /// <param name="current">A value betweem 0 and 3</param>
        protected override void setCurrent(short current)
        {
            //string init_string = String.Concat(SICL_interface_id, Convert.ToString(GPIB_adr));
            //InitIO(init_string);

            string command = String.Concat("I", current.ToString(), "\r\n");
            sendcommand(command);
            Thread.Sleep(50);
        }

       

        protected override void setRemoteMode()
        {
            //string init_string = String.Concat(SICL_interface_id, Convert.ToString(GPIB_adr));
            //InitIO(init_string);
            sendcommand("R1\n\r");
            Thread.Sleep(50);
        }

        protected override void Init()
        {
            //string init_string = String.Concat(SICL_interface_id, Convert.ToString(GPIB_adr));
            //InitIO(init_string);

            sendcommand("FORM:READ:TIME:TYPE ABS\r\n");
            Thread.Sleep(50);
            sendcommand("FORM:READ:TIME ON\r\n");
            Thread.Sleep(50);
            sendcommand("FORM:READ:CHAN OFF\r\n");
            Thread.Sleep(50);
            sendcommand("FORM:READ:ALAR OFF\r\n");
            Thread.Sleep(100);
        }

        /// <summary>
        /// -Returns the current temperature in degrees C
        /// </summary>
        /// <param name="multiplexor_channel">channel number is a value between 1 and 9</param>
        public override double getTemperature(PRT probe_type, short channel_number, bool probe_has_changed)
        {
            string resistance = "";
            double resistance_ = 0.0;
            double A = probe_type.getA();
            double B = probe_type.getB();
            double R0 = probe_type.getR0();

            //string init_string = String.Concat(SICL_interface_id, Convert.ToString(GPIB_adr));
            //InitIO(init_string);

            Init();

            //set the current channel
           // multi.setChannel(channel_number);
            
            if (probe_has_changed)
            {
                Thread.Sleep(100);   //wait 1 seconds for the bridge to settle after the channel change
            }
            else
            {
                //Thread.Sleep(500);  
            }
            //Do a measurement (MEAS) with four wire FRES
            string to_send = string.Concat("MEAS:FRES? 1000, 0.001, ", getAppendString());
            sendcommand(to_send);
            //Thread.Sleep(500);
            ReadResponse(ref resistance);

            try
            {
                resistance = ParseResistanceString(resistance);
                resistance_ = Convert.ToDouble(resistance);
            }
            catch (FormatException)
            {
                return -1;
            }
            resistance_ = resistance_ / base.Correction;
            return (-A + Math.Sqrt(A * A - 4 * B * (1 - (resistance_ / R0)))) / (2 * B);
        }
        /// <summary>
        /// -Unit must be between 0 and 3 which equates to 0.1mA, 0.3mA, 1mA and 3mA.
        /// </summary>
        /// <param name="unit">A value betweem 0 and 3</param>
        protected override void setUnits(short unit)
        {
            //string init_string = String.Concat(SICL_interface_id, Convert.ToString(GPIB_adr));
            //InitIO(init_string);

            string command = String.Concat("U", unit.ToString(), "\r\n");
            sendcommand(command);
            Thread.Sleep(500);
        }

        private string getAppendString()
        {
            AgilentMUX agilent_bridge_mux = (AgilentMUX)multi;
            return agilent_bridge_mux.AppendString;
        }

        private DateTime readDateTime()
        {
            string strDate = "";
            string strTime = "";

            sendcommand("SYST:DATE?\r\n");
            Thread.Sleep(50);
            ReadResponse(ref strDate);

            sendcommand("SYST:TIME?\r\n");
            Thread.Sleep(50);
            ReadResponse(ref strTime);

            return (DateTime) System.Convert.ToDateTime(string.Concat(strDate, strTime));
        }

        private void writeDateTime()
        {
            DateTime datetime;
            datetime = DateTime.Now;

            string strDate = datetime.Date.ToString();
            string strTime = datetime.TimeOfDay.ToString();

            sendcommand(string.Concat("SYST:DATE ", strDate, "\r\n"));
            Thread.Sleep(50);

            sendcommand(string.Concat("SYST:TIME ", strTime, "\r\n"));
            Thread.Sleep(50);
        }
        
    }
}
