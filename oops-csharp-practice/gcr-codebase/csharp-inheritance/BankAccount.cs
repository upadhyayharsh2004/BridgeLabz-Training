using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class BankAccount
    {
        protected string accountNumber;
        protected double balance;
        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public virtual void DisplayAccountType()
        {
            Console.WriteLine("ACCOUNT TYPE");
        }
    }
    class SavingsAccount : BankAccount
    {
        double interestRate;
        public SavingsAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("\nSAVINGS ACCOUNT DETAILS: ");

            Console.WriteLine("ACCOUNT TYPE: SAVINGS ACCOUNT");

            Console.WriteLine("BALANCE: " + balance);

            Console.WriteLine("INTEREST RATE: " + interestRate);
        }
    }
    class CheckingAccount : BankAccount
    {
        double withdrawalLimit;
        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
        {
            this.withdrawalLimit = withdrawalLimit;
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("\nCHECKING ACCOUNT DETAILS: ");

            Console.WriteLine("ACCOUNT TYPE: CHECKING ACCOUNT");

            Console.WriteLine("BALANCE: " + balance);

            Console.WriteLine("WITHDRAWAL LIMIT: " + withdrawalLimit);
        }
    }
    class FixedDepositAccount : BankAccount
    {
        int tenure;
        public FixedDepositAccount(string accountNumber, double balance, int tenure) : base(accountNumber, balance)
        {
            this.tenure = tenure;
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("\nFIXED DEPOSIT ACCOUNT DETAILS: ");

            Console.WriteLine("ACCOUNT TYPE: FIXED DEPOSIT ACCOUNT");

            Console.WriteLine("BALANCE: " + balance);

            Console.WriteLine("TENURE: " + tenure);
        }
    }

    //class containing Main method
    class BankAccountDemo
    {
        public static void Main(string[] args)
        {
            TakeInputs();
        } 
        public static void TakeInputs()
        {
            Console.Write("ENTER ACCOUNT NUMBER: ");
            string accountNumber = Console.ReadLine();
            Console.Write("ENTER BALANCE: ");
            double accountBalance = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER INTEREST RATE: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            BankAccount savingsAccount = new SavingsAccount(accountNumber, accountBalance, interestRate);
            Console.Write("\nENTER CHECKING ACCOUNT NUMBER: ");
            string accountNumber2 = Console.ReadLine();
            Console.Write("ENTER CHECKING ACCOUNT BALANCE: ");
            double accountBalance2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER WITHDRAWAL LIMIT: ");
            double withdrawalLimit = Convert.ToDouble(Console.ReadLine());
            BankAccount checkingAccount = new CheckingAccount(accountNumber2, accountBalance2, withdrawalLimit);
            Console.Write("\nENTER FIXED DEPOSIT ACCOUNT NUMBER: ");
            string accountNumber3 = Console.ReadLine();
            Console.Write("ENTER FIXED DEPOSIT ACCOUNT BALANCE: ");
            double accountBalance3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER  TENURE: ");
            int tenure = Convert.ToInt32(Console.ReadLine());
            BankAccount fixedDepositAccount = new FixedDepositAccount(accountNumber3, accountBalance3, tenure);
            savingsAccount.DisplayAccountType();
            checkingAccount.DisplayAccountType();
            fixedDepositAccount.DisplayAccountType();
        }
    }
}