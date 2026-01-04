
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Employee containing employee details
    internal class Employee
    {
        //protected variables for employee details
        protected string name;

        protected int id;

        protected double salary;

        //parameterized constructor for Employee class
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        //method to display details of an employee for our program
        public virtual void DisplayDetails()
        {
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("SALARY: " + salary);

        }

    }

    //derived class Manager from Employee
    class Manager : Employee
    {
        //private variable for team size
        int teamSize;

        //parameterized constructor for Manager class
        public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
        {
            this.teamSize = teamSize;
        }

        //override DisplayDetails method for Manager class
        public override void DisplayDetails()
        {
            //call base class DisplayDetails method for common details
            base.DisplayDetails();

            Console.WriteLine("TEAM SIZE: " + teamSize);
        }
    }

    //derived class Developer from Employee
    class Developer : Employee
    {
        //private variable for programming language
        string programmingLanguage;

        //parameterized constructor for Developer class
        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            this.programmingLanguage = programmingLanguage;
        }

        //override DisplayDetails method for Developer class
        public override void DisplayDetails()
        {
            //call base class DisplayDetails method for common details
            base.DisplayDetails();

            Console.WriteLine("PROGRAMMING LANGUAGE: " + programmingLanguage);
        }
    }

    //derived class Intern from Employee
    class Intern : Employee
    {
        //private variable for internship duration
        string internshipDuration;

        //parameterized constructor for Intern class
        public Intern(string name, int id, double salary, string internShipDuration) : base(name, id, salary)
        {
            this.internshipDuration = internShipDuration;
        }

        //override DisplayDetails method for Intern class
        public override void DisplayDetails()
        {
            //call base class DisplayDetails method for common details
            base.DisplayDetails();

            Console.WriteLine("DURATION: " + internshipDuration);
        }
    }

    //class containing Main method for our program
    class EmployeeDetails
    {
        public static void Main(string[] args)
        {
            //call the TakeInputs method
            TakeInputs();
        }

        //method to take user inputs in program
        public static void TakeInputs()
        {
            //take manager name input from user
            Console.Write("ENTER MANAGER NAME: ");
            string managerName = Console.ReadLine();

            //take manager id input from user
            Console.Write("ENTER MANAGER ID: ");
            int managerId = Convert.ToInt32(Console.ReadLine());

            //take manager salary input from user
            Console.Write("ENTER MANAGER SALARY: ");
            double managerSalary = Convert.ToDouble(Console.ReadLine());

            //take team size input from user
            Console.Write("ENTER TEAM SIZE: ");
            int teamSize = Convert.ToInt32(Console.ReadLine());

            //create object of Manager class for manager details
            Employee manager = new Manager(managerName, managerId, managerSalary, teamSize);

            //take developer name input fromuser
            Console.Write("\nENTER DEVELOPER NAME: ");
            string developerName = Console.ReadLine();

            //take developer id input from user
            Console.Write("ENTER DEVELOPER ID: ");
            int developerId = Convert.ToInt32(Console.ReadLine());

            //take developer salary input from user
            Console.Write("ENTER DEVELOPER SALARY: ");
            double developerSalary = Convert.ToDouble(Console.ReadLine());

            //take programming language input from user
            Console.Write("ENTER PROGRAMMING LANGUAGE: ");
            string programmingLanguage = Console.ReadLine();

            //create object of Developer class for developer details
            Employee developer = new Developer(developerName, developerId, developerSalary, programmingLanguage);

            //take intern name input from user 
            Console.Write("\nENTER INTERN NAME: ");
            string internName = Console.ReadLine();

            //take intern id input from user
            Console.Write("ENTER INTERN ID: ");
            int internId = Convert.ToInt32(Console.ReadLine());

            //take intern salary input from user
            Console.Write("ENTER INTERN SALARY: ");
            double internSalary = Convert.ToDouble(Console.ReadLine());

            //take internship duration input from user
            Console.Write("ENTER DURATION: ");
            string duration = Console.ReadLine();

            //create object of Intern class for intern details
            Employee intern = new Intern(internName, internId, internSalary, duration);

            //display manager details using DisplayDetails method for Manager class
            Console.WriteLine("\nMANAGER DETAILS: ");
            manager.DisplayDetails();

            //display developer details using DisplayDetails method for Developer class
            Console.WriteLine("\nDEVELOPER DETAILS: ");
            developer.DisplayDetails();

            //display intern details using DisplayDetails method for Intern class
            Console.WriteLine("\nINTERN DETAILS: ");
            intern.DisplayDetails();

        }
    }
}
