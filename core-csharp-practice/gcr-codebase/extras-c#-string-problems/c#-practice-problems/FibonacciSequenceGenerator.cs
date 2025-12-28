using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class FibonacciSequenceGenerator
    {
        public static void Main()
        {
            // Ask the user to enter the number of terms
            Console.WriteLine("Enter the number of terms for the Fibonacci sequence:");
            int terms=Convert.ToInt32(Console.ReadLine());
            // Call the function to generate and print the Fibonacci sequence
            GenerateFibonacci(terms);
        }
        // Function to generate and print the Fibonacci sequence
        // Parameter: int n - number of terms to generate
        // Return type: void (sequence is printed inside the function)
        static void GenerateFibonacci(int n)
        {
            // First two numbers of the Fibonacci sequence
            int first=0;
            int second=1;
            // Check if the number of terms is valid
            if(n<=0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }
            Console.WriteLine("Fibonacci Sequence:");
            // Generate Fibonacci numbers up to n terms
            for(int i=1;i<=n; i++)
            {
                // Print the current number
                Console.Write(first+"");
                // Calculate the next number
                int next=first+second;
                first=second;
                second=next;
            }
            // Move to the next line after printing the sequence
            Console.WriteLine();
        }
    }
}
