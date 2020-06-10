using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Laptop : Computer
    {
        public bool IsConnected { get; set; }

        public Laptop (string processor, int memory, double storage, string operatingSystem) : base(processor, memory, storage, operatingSystem)
        {
            IsConnected = false;
        }

        public void Connect()
        {
            IsConnected = true;
        }

        public string RunProgram (string programName)
        {
            if (IsConnected)
            {
                return $"Program {programName}, running!";
            }
            else
            {
                return $"Program {programName}, cannot connect. Please connect to wifi and try again!";
            }
        }
    }
}
