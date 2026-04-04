using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
namespace Bridgelabz.Training_oops_scenario_based_Employee_Wages_Problems
{
    public class EmployeeMenu
    {
        public static void ShowMenu(IEmployee service)
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Employee Menu ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Calculate Monthly Wage");
                Console.WriteLine("3. Display Employee");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddEmployee();
                        break;

                    case 2:
                        service.CalculateMonthlyWage();
                        break;

                    case 3:
                        service.DisplayEmployee();
                        break;

                    case 4:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}