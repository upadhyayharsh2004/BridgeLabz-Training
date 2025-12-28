using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class FormatDate
    {
        public static void Main()
        {
            // Get current date
            DateTime currentDate=DateTime.Now;
            // Display date in different formats
            Console.WriteLine("Current Date in Different Formats:\n");
            Console.WriteLine("dd/MM/yyyy:"+currentDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("yyyy-MM-d:"+currentDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("EEE,MMM dd,yyyy:"+currentDate.ToString("ddd,MMM dd, yyyy"));
        }
    }
}
