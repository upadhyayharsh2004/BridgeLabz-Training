using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class PrimeNumberChecker
    {
        public static void Main()
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");
            int number=Convert.ToInt32(Console.ReadLine());
            // Call the function to check if the number is prime
            bool isPrime=CheckPrime(number);
            // Display the result
            if(isPrime)
            {
                Console.WriteLine(number+"is a prime number.");
            }
            else
            {
                Console.WriteLine(number+"is not a prime number.");
            }
        }
        // Function to check whether a number is prime
        // Parameter: int num - number to be checked
        // Return type: bool - true if prime, false otherwise
        static bool CheckPrime(int num)
        {
            // Numbers less than or equal to 1 are not prime
            if(num<=1)
            {
                return false;
            }
            // Check divisibility from 2 up to half of the number
            for(int i=2;i<=num/2;i++)
            {
                // If divisible, number is not prime
                if(num%i==0)
                {
                    return false;
                }
            }
            // If no divisors found, number is prime
            return true;
        }
    }
}
