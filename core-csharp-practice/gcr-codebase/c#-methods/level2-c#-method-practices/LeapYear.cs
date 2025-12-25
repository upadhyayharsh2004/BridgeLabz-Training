using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class LeapYear
    {
        public static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYear leapYear = new LeapYear();
            bool resultOfYear = leapYear.LeapYearCheck(year);
            if (resultOfYear)
            {
                Console.WriteLine("The Year" + " " + year + " " + "Is A Leap Year");
            }
            else
            {
                Console.WriteLine("The Year" + " " + year + " " + "Is Not A Leap Year");
            }
        }
        public bool LeapYearCheck(int year)
        {
            if (year < 1582)
            {
                return false;
            }
            else if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
