﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trolley_Control
{
    public class Laser_Aux:DUT
    {
        public Laser_Aux(ref DUTUpdateGui dutug_) : base(dutug_)
        {
            unit_timeout = 1000;  // 1000ms for a laser device, they always respond quickly
            device_name = "Laser Aux";
           
        }
        public override bool Request(string request, ref string result)
        {
            throw new NotImplementedException();
        }

        public override void setTimeOut(int num_samples)
        {
            TCPClient.Timeout = unit_timeout*num_samples;
        }
    }

   
}
