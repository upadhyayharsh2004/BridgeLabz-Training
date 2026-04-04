using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_and_object.level_1
{
    internal class Employee
    {
        private string name;
        private string id;
        private int salary;
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter Employee Name: ");
            emp.name = Console.ReadLine();
            Console.Write("Enter Employee Id: ");
            emp.id = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            emp.DisplayDetails();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS ARE: ");

            Console.WriteLine("Name: " + name);

            Console.WriteLine("Id: " + id);

            Console.WriteLine("Salary: " + salary);
        }
    }
}