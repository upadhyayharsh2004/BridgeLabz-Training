using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.Training_oops_scenario_based_Employee_Wages_Problems
{
    public class EmployeeMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Employee employee = new Employee(101, "John");
            IEmployee service = new EmployeeUtilityImpl();
            EmployeeMenu.ShowMenu(service);
            Console.ReadLine();
        }
    }

}
