using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.c__smart_house_automation
{
    class SmartHomeMain
    {
        static void Main()
        {
            ApplianceUtilityImpl utility = new ApplianceUtilityImpl();

            utility.ControlLight();
            Console.WriteLine();

            utility.ControlFan();
            Console.WriteLine();

            utility.ControlAC();
        }
    }
}
