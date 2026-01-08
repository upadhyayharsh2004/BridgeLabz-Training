using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.c__smart_house_automation
{
    class AC : Appliance
    {
        public AC() : base("Air Conditioner") { }
        public override void TurnOn()
        {
            Console.WriteLine("AC is turned ON at 24°C cooling mode.");
        }
        public override void TurnOff()
        {
            Console.WriteLine("AC is turned OFF.");
        }
    }
}
