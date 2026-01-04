using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenario_based
{
    internal class BankAccount
    {
        //attributes
        static string bankName = "STATE BANK OF INDIA";

        static int totalAccounts;

        readonly int accountNumber = 10;

        string accountHolderName;

        //method to get total accounts
        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        //create parameterized constructor
        BankAccount(int accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            totalAccounts++;
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
            //take account Number input
            Console.WriteLine("ENTER ACCOUNT NUMBER: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            //take holder name input
            Console.WriteLine("ENTER HOLDER NAME: ");
            string holderName = Console.ReadLine();

            // Ensure holderName is not null before creating BankAccount
            if (string.IsNullOrWhiteSpace(holderName))
            {
                Console.WriteLine("Holder name cannot be empty. Please try again.");
                return;
            }

            //create object
            BankAccount bankAccount = new BankAccount(accountNumber, holderName);

            if (bankAccount is BankAccount)
            {
                bankAccount.DisplayDetails();

                Console.WriteLine("Total Accounts: " + GetTotalAccounts());
            }
        }

        //--------------DISPLAY DETAILS----------------
        //method to display all details
        public void DisplayDetails()
        {

            Console.WriteLine("\n--- BANK ACCOUNT DETAILS ---");

            Console.WriteLine("BANK NAME: " + bankName);

            Console.WriteLine("ACCOUNT NUMBER: " + accountNumber);

            Console.WriteLine("HOLDER NAME: " + accountHolderName);
        }

    }
}