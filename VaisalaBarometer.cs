using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace Trolley_Control
{
    public struct ProcNameSerialCom
    {
        public const short CHECKCOMPORTS = 0;
        public const short POLL = 1;
        public const short IDLE = 255;
    }
    public class VaisalaBarometer:SerialCom
    {

        private Thread serialPortThread;
        

        public VaisalaBarometer(ref VaisalaUpdateGui pbarug)
        {
            update_gui = pbarug;
            error_reported = false;

            //thread to control and monitor the barometer
            serialPortThread = new Thread(new ThreadStart(Query));
            serialPortThread.Start();

            current_exe_stage = ProcNameSerialCom.CHECKCOMPORTS;

        }

      

        public override bool CheckComPorts()
        {
            //get the names of all the com ports
            string[] ports = SerialPort.GetPortNames();

            foreach (string portname in ports)
            {
                Thread.Sleep(100);
                if (Init(portname))
                {
                    break;   //this sets the correct serial port and the port is now open for comunication
                }
                
            }
            if (!s_port.IsOpen)
            {
                if (!ErrorReported)
                {
                    update_gui(ProcNameSerialCom.CHECKCOMPORTS, "Barometer Error - Could not find a valid serial COM port - Check the barometer is connected and there is a relevant COM port in the Windows Device manager", true);
                    
                }
                Thread.Sleep(5000);
                return false;
            }
            return true;

        }

        
        public override bool Init(string portname)
        {

            try
            {
                //create a new serial port
                s_port = new SerialPort();

                s_port.PortName = portname;

                s_port.BaudRate = 9600;
                s_port.Parity = Parity.Even;
                s_port.DataBits = 7;
                s_port.StopBits = StopBits.One;
                s_port.Handshake = Handshake.None;
                s_port.RtsEnable = false;
                s_port.DtrEnable = false;
                s_port.ReadTimeout = 2000;
                s_port.WriteTimeout = 1000;
                s_port.Open();
                s_port.DiscardInBuffer();

                is_open = true;

                //put the barometer into broadcast mode
                s_port.Write("send\r");
                //Thread.Sleep(800); //leave a bit of time for a response
                Thread.Sleep(800);
                //check what we get back is correct
                
                string line = s_port.ReadLine();
                

                if (line.Contains("hPa"))
                {
                    return true;
                }

                else
                {
                    //s_port.Close();
                    return false;
                }


            }
            catch (IOException)
            {
                
                s_port.Close();
                is_open = false;
                return false;
            }
            catch (TimeoutException)
            {
                s_port.Close();
                is_open = false;
                return false;
            }
            catch (AccessViolationException)
            {
                update_gui(ProcNameSerialCom.CHECKCOMPORTS, "Barometer Error - Serial Port Already Open", true);
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                update_gui(ProcNameSerialCom.CHECKCOMPORTS, "Barometer Error - Serial Port Already Open", true);
                return false;
            }
        }


        public override bool Read()
        {
            //read if the port is open
            if (s_port.IsOpen)
            {
                s_port.WriteLine("send\r");
                Thread.Sleep(1000);
                try
                {
                    string line = s_port.ReadLine();
                    ParseForResult(line);
                    error_reported = false;
                    return true;

                }
                catch (TimeoutException)
                {
                    is_open = false;
                    s_port.Close();
                    current_exe_stage = ProcNameSerialCom.CHECKCOMPORTS;
                    return false;
                }
                catch (System.InvalidOperationException)
                {
                    update_gui(ProcNameSerialCom.CHECKCOMPORTS, "The Vaisala Serial Port Has Unexpectedly Closed", true);
                    return false;
                }
                catch (IOException)
                {
                    return false;
                }
            }
            else
            {
                is_open = false;
                s_port.Close();
                current_exe_stage = ProcNameSerialCom.CHECKCOMPORTS;
                return false;
            }
                
            
            
        
        }
        public void Write(string command)
        {
            s_port.Write(command);
        }
        
        public bool ClearError()
        {
            //clear the error
            try
            {
                s_port.Write("reset\r");
                string line = s_port.ReadLine();
                if (line.Contains("PTB220")) return true;
                else
                {
                    current_exe_stage = ProcNameSerialCom.CHECKCOMPORTS;  //return to the init state
                    return false;
                }
            }
            catch (IOException)
            {
                s_port.Close();
                current_exe_stage = ProcNameSerialCom.CHECKCOMPORTS;  //return to the init state
                return false;
            }
            catch (TimeoutException)
            {
                s_port.Close();
                current_exe_stage = ProcNameSerialCom.CHECKCOMPORTS;  //return to the init state
                return false;
            }
            
        }


        public double ParseForResult(string line)
        {
            if (line.Contains("hPa"))
            {
                string substring = line.Substring(0, line.IndexOf('h'));
                try
                {
                    result = Convert.ToDouble(substring);
                }
                catch (FormatException e)
                {
                    update_gui(ProcNameSerialCom.POLL, e.ToString(), true);
                }

                return result;
            }
            else return 0.00;
        }

        public void Query()
        {
            while (true)
            {
                Thread.Sleep(10); //stop the thread from thrashing
                switch (current_exe_stage)
                {
                    case ProcNameSerialCom.CHECKCOMPORTS:
                        //We only execute if an error has not been reported to the gui

                        
                        if (!ErrorReported)
                        {
                            if (CheckComPorts()){
                                //we have a com port assigned and valid communication so we can move on
                                current_exe_stage = ProcNameSerialCom.POLL;
                            }
                        }
                        break;
                    case ProcNameSerialCom.POLL:
                        
                        if (Read())
                        {
                            update_gui(ProcNameSerialCom.POLL, "No Error", false);
                        }
                        else current_exe_stage = ProcNameSerialCom.CHECKCOMPORTS;


                        break;
                    case ProcNameSerialCom.IDLE:
                        Thread.Sleep(1000); 
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
