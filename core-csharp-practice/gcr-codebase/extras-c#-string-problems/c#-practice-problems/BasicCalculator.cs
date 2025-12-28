using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class BasicCalculator
    {
        public static void Main()
        {
            // Display calculator menu
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter your choice (1-4):");
            int choice=Convert.ToInt32(Console.ReadLine());
            // Get two numbers from the user
            Console.WriteLine("Enter first number:");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2=Convert.ToDouble(Console.ReadLine());
            // Perform the selected operation
            if (choice==1)
            {
                double result=Add(num1,num2);
                Console.WriteLine("Result:"+ result);
            }
            else if (choice==2)
            {
                double result=Subtract(num1,num2);
                Console.WriteLine("Result:"+result);
            }
            else if (choice==3)
            {
                double result=Multiply(num1,num2);
                Console.WriteLine("Result:"+result);
            }
            else if (choice==4)
            {
                // Check for division by zero
                if (num2!= 0)
                {
                    double result=Divide(num1,num2);
                    Console.WriteLine("Result:"+result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }
            else
            {
                // Handle invalid choice
                Console.WriteLine("Invalid choice.");
            }
        }
        // Function to add two numbers
        // Parameters:
        // double a - first number
        // double b - second number
        // Return type:double-sum
        static double Add(double a,double b)
        {
            return a+b;
        }
        // Function to subtract two numbers
        // Parameters:
        // double a-first number
        // double b-second number
        // Return type: double-difference
        static double Subtract(double a,double b)
        {
            return a-b;
        }  
        // Function to multiply two numbers
        // Parameters:
        // double a-first number
        // double b-second number
        // Return type:double-product
        static double Multiply(double a,double b)
        {
            return a*b;
        }

        // Function to divide two numbers
        // Parameters:
        // double a - first number
        // double b - second number
        // Return type: double - quotient
        static double Divide(double a,double b)
        {
            return a/b;
        }
    }
}
