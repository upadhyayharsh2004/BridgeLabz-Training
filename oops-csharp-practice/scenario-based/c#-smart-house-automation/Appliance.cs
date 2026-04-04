using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.c__smart_house_automation
{
    abstract class Appliance : IControllable
    {
        protected string applianceName;
        public Appliance(string name)
        {
            applianceName = name;
        }
        public abstract void TurnOn();
        public abstract void TurnOff();
        public void GetApplianceDetails()
        {
            Console.WriteLine("Appliance : " + applianceName);
        }
    }
}
