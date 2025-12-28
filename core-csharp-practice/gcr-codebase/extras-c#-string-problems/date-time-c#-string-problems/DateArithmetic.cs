using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class DateArithmetic
    {
        public static void Main()
        {
            // Take date input from user
            Console.Write("Enter a date (yyyy-MM-dd): ");
            DateTime inputDate=DateTime.Parse(Console.ReadLine());
            // Add 7 days, 1 month, and 2 years
            DateTime resultDate=inputDate.AddDays(7).AddMonths(1).AddYears(2);
            // Subtract 3 weeks (3 × 7 = 21 days)
            resultDate=resultDate.AddDays(-21);
            // Display result
            Console.WriteLine("\nFinal Date After Calculations:");
            Console.WriteLine(resultDate.ToString("yyyy-MM-dd"));
        }
    }
}
