using ;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.Training_oops_scenario_based_Employee_Wages_Problems
{
    public class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;
        public const int IS_ABSENT = 0;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOURS = 8;
        public const int PART_TIME_HOURS = 4;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;

        public void AddEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            employee = new Employee(id, name);
            Console.WriteLine("Employee Added Successfully!");
        }

        public void CalculateMonthlyWage()
        {
            if (employee == null)
            {
                Console.WriteLine("Please add employee first!");
                return;
            }

            Random random = new Random();

            while (employee.TotalDays < MAX_WORKING_DAYS &&
                   employee.TotalHours < MAX_WORKING_HOURS)
            {
                int empCheck = random.Next(0, 3);
                int workHours;

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        workHours = FULL_DAY_HOURS;
                        break;

                    case IS_PART_TIME:
                        workHours = PART_TIME_HOURS;
                        break;

                    default:
                        workHours = 0;
                        break;
                }

                employee.AddHours(workHours);
                employee.AddWage(workHours * WAGE_PER_HOUR);
                employee.AddDay();
            }

            Console.WriteLine("Monthly Wage Calculated!");
        }

        public void DisplayEmployee()
        {
            if (employee == null)
            {
                Console.WriteLine("No employee found!");
                return;
            }

            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("ID          : " + employee.EmpId);
            Console.WriteLine("Name        : " + employee.EmpName);
            Console.WriteLine("Total Days  : " + employee.TotalDays);
            Console.WriteLine("Total Hours : " + employee.TotalHours);
            Console.WriteLine("Total Wage  : " + employee.TotalWage);
        }

        public void CalculateMonthlyWage(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
