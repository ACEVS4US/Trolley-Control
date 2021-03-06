﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Trolley_Control
{
    abstract class ResistanceBridge : GPIBOverLANCommands
    {

        //private const int F26_bridge_adr = 15;
        protected MUX multi;
        protected Object thislock = new Object();
        protected double correction;
        
        
        protected short current_channel_in_use;

        public ResistanceBridge(int GPIB_Address_, string SICL_,ref MUX multi_)
        {
            base.GPIB_adr = GPIB_Address_;
            base.SICL_interface_id = SICL_;
            multi = multi_;
        }

        protected abstract void setRemoteMode();
        

        /// <summary>
        /// - Current must be between 0 and 3 which equates to 0.1mA, 0.3mA, 1mA and 3mA.
        /// </summary>
        /// <param name="current">A value betweem 0 and 3</param>
        protected abstract void setCurrent(short current);
        

        /// <summary>
        /// -Unit must be between 0 and 3 which equates to 0.1mA, 0.3mA, 1mA and 3mA.
        /// </summary>
        /// <param name="unit">A value betweem 0 and 3</param>
        protected abstract void setUnits(short unit);


        protected abstract void Init();

        /// <summary>
        /// -Returns the current temperature in degrees C
        /// </summary>
        /// <param name="multiplexor_channel">channel number is a value between 1 and 9</param>
        public abstract double getTemperature(PRT probe_type, short channel_number, bool probe_has_changed);
        
        public void setMUX(ref MUX mux){
            multi = mux;
        }
        /// <summary>
        /// -Gets a probe with the specified channel type
        /// </summary>
        /// <param name="multiplexor_channel">A channel type</param>
        protected PRT getProbe(string probe_name)
        {
            return multi.getProbe(probe_name);
        }
        protected short getCurrentChannel()
        {
            return current_channel_in_use;
        }

        public double Correction
        {
            get { return correction; }
            set { correction = value; }
        }

        public void setCurrentChannel(short channel)
        {
            lock (thislock)
            {
                multi.setChannel(channel);
            }
        }

        /// <summary>
        /// -Removes the bad stuff out of the string so that it can be converted to a double
        /// </summary>
        /// <param name="multiplexor_channel">A channel type</param>
        protected string ParseResistanceString(string resistance)
        {
            if (resistance.Contains('+'))
            {
                int index = resistance.IndexOf('+');
                resistance.Remove(index, 1);
            }
            return resistance;
        }

    }
}
