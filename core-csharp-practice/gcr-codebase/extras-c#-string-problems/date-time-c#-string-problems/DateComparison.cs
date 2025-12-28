using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class DateComparison
    {
        public static void Main()
        {
            // Take first date input
            Console.Write("Enter first date (yyyy-MM-dd): ");
            DateTime date1=DateTime.Parse(Console.ReadLine());
            // Take second date input
            Console.Write("Enter second date (yyyy-MM-dd): ");
            DateTime date2=DateTime.Parse(Console.ReadLine());
            // Compare dates
            int result=DateTime.Compare(date1, date2);
            // Display comparison result
            if (result<0)
            {
                Console.WriteLine("First date is BEFORE the second date.");
            }
            else if(result>0)
            {
                Console.WriteLine("First date is AFTER the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the SAME.");
            }
        }
    }
}
