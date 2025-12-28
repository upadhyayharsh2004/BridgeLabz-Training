using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class MaximumOfThreeNumbers
    {
        public static void Main()
        {
            // Get three numbers from the user
            int num1=GetNumberFromUser("Enter first number:");
            int num2=GetNumberFromUser("Enter second number:");
            int num3=GetNumberFromUser("Enter third number:");
            // Find the maximum number using a separate function
            int max=FindMaximum(num1,num2,num3);
            // Display the maximum number
            Console.WriteLine("The maximum of the three numbers is:"+max);
        }
        // Function to take an integer input from the user
        // Parameter: string message-message to display to the user
        // Return type:int-integer entered by the user
        static int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number=Convert.ToInt32(Console.ReadLine());
            return number;
        }
        // Function to find the maximum of three integers
        // Parameters:
        // int a-first number
        // int b-second number
        // int c-third number
        // Return type: int-maximum value
        static int FindMaximum(int a,int b,int c)
        {
            // Assume the first number is the maximum initially
            int max=a;
            // Compare with second number
            if(b>max)
            {
                max=b;
            }
            // Compare with third number
            if(c>max)
            {
                max=c;
            }
            // Return the maximum value
            return max;
        }
    }
}
