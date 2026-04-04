using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Employee
{
    //attributes
    static string CompanyName = "IBM";
        
    static int totalEmployees = 0;

    string Name;

    readonly int id;

    string Designation;

    //method to get total accounts
    public static int DisplayTotalEmployees()
    {
        return totalEmployees;
    }

    //create parameterized constructor
    Employee(string Name, int id, string Designation)
    {
        this.Name = Name;
        this.id = id;
        this.Designation = Designation;
        totalEmployees++;
    }
    public static void Main(string[] args)
    {
        //call TakeInputs method
        TakeInputs();
    }

    //------------TAKE INPUTS-----------------
    //method to take user inputs
    public static void TakeInputs()
    {
        //take employee name input
        Console.WriteLine("ENTER EMPLOYEE NAME: ");
        string Name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(Name))
        {
            Console.WriteLine("Employee name cannot be empty.");
            return;
        }
        //take employee id input
        Console.WriteLine("ENTER EMPLOYEE ID: ");
        string idInput = Console.ReadLine();
        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid employee ID.");
            return;
        }
        //take employee designation input
        Console.WriteLine("ENTER EMPLOYEE DESIGNATION: ");
        string Designation = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(Designation))
        {
            Console.WriteLine("Employee designation cannot be empty.");
            return;
        }

        //create object
        // BankAccount bankAccount = new BankAccount(accountNumber, holderName);
        Employee employee = new Employee(Name, id, Designation);
        if (employee is Employee)
        {
            employee.DisplayDetails();
            Console.WriteLine("Total Employees: " + DisplayTotalEmployees());
        }
    }
    //--------------DISPLAY DETAILS----------------
    //method to display all details
    public void DisplayDetails()
    {

        Console.WriteLine("\n--- EMPLOYEE DETAILS ---");

        Console.WriteLine("Company Name:" + " " + CompanyName);

        Console.WriteLine("EMPLOYEE NAME: " + Name);

        Console.WriteLine("EMPLOYEE ID: " + id);

        Console.WriteLine("EMPLOYEE DESIGNATION: " + Designation);
    }
}

