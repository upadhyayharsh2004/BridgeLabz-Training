using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.c__smart_house_automation
{
    class Light : Appliance
    {
        public Light() : base("Light") { }
        public override void TurnOn()
        {
            Console.WriteLine("Light is turned ON with normal brightness.");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Light is turned OFF.");
        }
    }
}
