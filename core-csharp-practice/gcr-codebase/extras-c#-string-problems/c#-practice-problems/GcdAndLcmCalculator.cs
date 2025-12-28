using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class GcdAndLcmCalculator
    {
        public static void Main()
        {
            // Get two numbers from the user
            int num1=GetNumberFromUser("Enter the first number:");
            int num2=GetNumberFromUser("Enter the second number:");
            // Calculate GCD using a separate function
            int gcd=CalculateGcd(num1, num2);
            // Calculate LCM using a separate function
            int lcm=CalculateLcm(num1,num2,gcd);
            // Display the results
            DisplayResults(num1,num2,gcd,lcm);
        }
        // Function to take integer input from the user
        // Parameter:string message-message to display
        // Return type:int-number entered by the user
        static int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number=Convert.ToInt32(Console.ReadLine());
            return number;
        }
        // Function to calculate GCD using Euclidean algorithm
        // Parameters:
        // int a-first number
        // int b-second number
        // Return type: int-GCD value
        static int CalculateGcd(int a,int b)
        {
            // Apply Euclidean algorithm
            while (b!=0)
            {
                int remainder=a%b;
                a=b;
                b=remainder;
            }
            return a;
        }
        // Function to calculate LCM using GCD
        // Parameters:
        // int a-first number
        // int b-second number
        // int gcd-greatest common divisor of a and b
        // Return type: int-LCM value
        static int CalculateLcm(int a,int b,int gcd)
        {
            // Formula to calculate LCM
            int lcm=(a*b)/gcd;
            return lcm;
        }
        // Function to display GCD and LCM results
        // Parameters:
        // int a-first number
        // int b-second number
        // int gcd-calculated GCD
        // int lcm-calculated LCM
        static void DisplayResults(int a,int b,int gcd,int lcm)
        {
            Console.WriteLine("GCD of"+a+"and"+b+"is:"+gcd);
            Console.WriteLine("LCM of"+a+"and"+b +"is:"+lcm);
        }
    }
}
