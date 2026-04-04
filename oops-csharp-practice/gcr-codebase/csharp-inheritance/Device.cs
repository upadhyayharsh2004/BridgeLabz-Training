using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Device for device details
    internal class Device
    {
        //protected variables for device details
        protected string deviceId;

        protected string status;

        //parameterized constructor for Device class
        public Device(string deviceId, string status)
        {
            this.deviceId = deviceId;
            this.status = status;
        }

        //method to display device details  for our program
        public virtual void DisplayStatus()
        {
            Console.WriteLine("DEVICE ID: " + deviceId);
            Console.WriteLine("DEVICE STATUS: " + status);
        }
    }

    //derived class Thermostat for device details
    class Thermostat : Device
    {
        //private variable for temperature setting
        int temperatureSetting;

        //parameterized constructor for Thermostat class
        public Thermostat(string deviceId, string status, int temperatureSetting) : base(deviceId, status)
        {
            this.temperatureSetting = temperatureSetting;
        }

        //override DisplayStatus method to include temperature setting
        public override void DisplayStatus()
        {
            //call base class DisplayStatus method to display device details
            base.DisplayStatus();

            Console.WriteLine("TEMPERATURE: " + temperatureSetting);
        }
    }

    //class containing Main method for our program
    class DeviceDetails
    {
        public static void Main(string[] args)
        {
            //call TakeInputs method for inputs
            TakeInputs();
        }

        //method to take user inputs in program
        public static void TakeInputs()
        {
            //take device id input from user
            Console.Write("ENTER DEVICE ID: ");
            string id = Console.ReadLine();

            //take device status input from user
            Console.Write("ENTER DEVICE STATUS: ");
            string status = Console.ReadLine();

            //take temperature setting input from user
            Console.Write("ENTER TEMPERATURE SETTING: ");
            int temperatureSetting = Convert.ToInt32(Console.ReadLine());

            //create object of Thermostat class for device details
            Device device = new Thermostat(id, status, temperatureSetting);

            //call DisplayStatus method to display device details
            Console.WriteLine("\nDEVICE DETAILS: ");

            device.DisplayStatus();


        }
    }
}