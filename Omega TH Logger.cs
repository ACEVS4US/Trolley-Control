using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Trolley_Control
{

    public struct ProcNameHumidity
    {
        public const short CONNECT = 0;
        public const short SEND_RECEIVE = 1;
        public const short IDLE = 255;
    }

   
    public class OmegaTHLogger
    {
        THLoggerUpdateGUI h_update;
        
        private Client TcpClient;
        private string hostname;
        private static short num_connected_loggers = 0;
        private int timer_zero1;
        private int timer_zero2;
        private int timer_1;
        private int timer_2;
        private double humidity_result = 50.00;
        private bool error_reported=false;
        private bool isactive = false;
        private short dev_id = 255;

  
        
        

        public OmegaTHLogger(string hostname_, ref THLoggerUpdateGUI th_update)
        {
            TcpClient = new Client();
            h_update = th_update;
            hostname = hostname_;
        }
        public double getH
        {
            get { return humidity_result; }
        }
        public short devID
        {
            get { return dev_id; }
            set { dev_id = value; }
        }

        public void HLoggerQuery(object stateinfo)
        {

            timer_zero1 = Environment.TickCount;
            timer_zero2 = Environment.TickCount;
            timer_1 = timer_zero1 + 10000;
            timer_2 = timer_zero2 + 20000;

            while (true)
            {
                //get the latest times
                timer_1 = Environment.TickCount;
                timer_2 = Environment.TickCount;
                
                
                //if we haven't had a valid humidity reading for more than 30 s then set to inactive
                if(timer_2 > timer_zero2 + 30000)
                {
                    if (isactive == true )num_connected_loggers--;
                    isactive = false;
                    
                }

                //check if we are connected
                if (TcpClient.isConnected())
                {

                   
                    Thread.Sleep(5000);  //we only sample the logger every 5 seconds
                    string result="";
                    if (TcpClient.sendReceiveData("*SRH\r", ref result))
                    {
                        try
                        {
                            double result_ = Convert.ToDouble(result);
                            humidity_result = result_;
                            error_reported = false;
                            h_update(ProcNameHumidity.SEND_RECEIVE, "No Error", false);
                            if(isactive == false) num_connected_loggers++;
                            isactive = true;
                            
                            timer_zero2 = Environment.TickCount;
                            error_reported = false;
                        }
                        catch (FormatException e)
                        {
                            h_update(ProcNameHumidity.SEND_RECEIVE, e.ToString(), true);
                            continue;
                        }
                    }
                    else
                    {
                        if (!error_reported)
                        {
                            h_update(ProcNameHumidity.SEND_RECEIVE, "An orror occured sending/receiving data from the humidity device", true);   //error not reported - report
                            error_reported = true;
                        }
                    }

                    
                }
                else
                {
                    //we're not connected - attempt to connect. We don't want to do this too often because it has a high overhead, try connecting every 10s
                    if (timer_1 >= timer_zero1 + 10000) {
                        if (!TryConnect())
                        {
                            if (!error_reported)
                            {
                                h_update(ProcNameHumidity.CONNECT, "An error occurred connecting to Humidity device " + devID.ToString(), true);
                                error_reported = true;
                            }
                        }
                        timer_zero1 = Environment.TickCount;
                    }
                }

            }

        }

        public bool TryConnect()
        {
            return TcpClient.Connect(hostname);
        }

        public void setHostName(string hostname_)
        {
            hostname = hostname_;
        }
        public bool isActive
        {
            get { return isactive;  }
        }

        public static short numConnectedLoggers
        {
            get { return num_connected_loggers; }
        }  
    }
}
