using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_access_modifiers
{
    internal class Employee
    {
        public string employeeId;
        protected string department;
        private int salary;
        public void SetSalary(int newSalary)
        {
            this.salary = newSalary;
        }
        public int GetSalary()
        {
            return salary;
        }
        class Manager : Employee
        {
            public static void Main(string[] args)
            {
                TakeInputs();
            }
            public static void TakeInputs()
            {
                Manager manager = new Manager();
                Console.WriteLine("\nENTER EMPLOYEE ID: ");
                manager.employeeId = Console.ReadLine();
                Console.WriteLine("ENTER DEPARTMENT: ");
                manager.department = Console.ReadLine();
                Console.WriteLine("ENTER SALARY: ");
                manager.SetSalary(Convert.ToInt32(Console.ReadLine()));
                manager.DisplayDetails();

            }
            public void DisplayDetails()
            {
                Console.WriteLine("\nEMPLOYEE ID: " + employeeId);

                Console.WriteLine("EMPLOYEE DEPARTMENT: " + department);

                Console.WriteLine("EMPLOYEE SALARY: " + GetSalary());
            }
        }
    }
}