using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class FactorialUsingRecursion
    {
        public static void Main()
        {
            // Get the number from the user
            int number=GetNumberFromUser();
            // Calculate the factorial using recursion
            long factorial=CalculateFactorial(number);
            // Display the result
            DisplayResult(number,factorial);
        }
        // Function to take integer input from the user
        // Return type:int-number entered by the user
        static int GetNumberFromUser()
        {
            Console.WriteLine("Enter a number:");
            int num=Convert.ToInt32(Console.ReadLine());
            return num;
        }
        // Recursive function to calculate factorial
        // Parameter:int n-number for which factorial is calculated
        // Return type:long-factorial result
        static long CalculateFactorial(int n)
        {
            // Base case: factorial of 0 or 1 is 1
            if(n==0||n==1)
            {
                return 1;
            }
            // Recursive case
            return n*CalculateFactorial(n-1);
        }
        // Function to display the result
        // Parameters:
        // int number-input number
        // long result-factorial value
        static void DisplayResult(int number,long result)
        {
            Console.WriteLine("Factorial of"+number+"is:"+result);
        }
    }
}
