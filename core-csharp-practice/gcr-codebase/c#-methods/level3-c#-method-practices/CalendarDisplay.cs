using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class CalendarDisplay
    {
        public static void Main(string[] args)
        {
            // Taking user input for month and year
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            // Getting the month name
            string monthName = GetMonthName(month);

            // Getting number of days in the month
            int daysInMonth = GetDaysInMonth(month, year);

            // Getting the first day of the month
            int firstDay = GetFirstDayOfMonth(month, year);

            // Displaying the calendar header
            Console.WriteLine("   " + monthName + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // First loop to print initial spaces based on first day
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            // Second loop to print all days of the month
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write(String.Format("{0,3} ", day));

                // Move to next line after Saturday
                if ((day + firstDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        // Method to get the name of the month
        public static string GetMonthName(int month)
        {
            string[] months =
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            return months[month - 1];
        }

        // Method to get the number of days in the month
        public static int GetDaysInMonth(int month, int year)
        {
            int[] days =
            {
                31, 28, 31, 30, 31, 30,
                31, 31, 30, 31, 30, 31
            };

            // Checking for February in a leap year
            if (month == 2 && IsLeapYear(year))
            {
                return 29;
            }

            return days[month - 1];
        }

        // Method to check whether a year is a leap year
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }

            return false;
        }

        // Method to get the first day of the month using Gregorian calendar algorithm
        public static int GetFirstDayOfMonth(int month, int year)
        {
            int d = 1;
            int m = month;
            int y = year;

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;
        }
    }
}
