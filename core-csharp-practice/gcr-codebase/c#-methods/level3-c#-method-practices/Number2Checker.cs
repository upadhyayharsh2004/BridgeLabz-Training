using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class Number2Checker
    {
        public static void Main(string[] args)
        {
            // Taking user input for the number
            int number = Convert.ToInt32(Console.ReadLine());

            // Calling method to check whether the number is Prime
            bool isPrime = IsPrimeNumber(number);
            Console.WriteLine("Is Prime Number = " + isPrime);

            // Calling method to check whether the number is Neon
            bool isNeon = IsNeonNumber(number);
            Console.WriteLine("Is Neon Number = " + isNeon);

            // Calling method to check whether the number is Spy
            bool isSpy = IsSpyNumber(number);
            Console.WriteLine("Is Spy Number = " + isSpy);

            // Calling method to check whether the number is Automorphic
            bool isAutomorphic = IsAutomorphicNumber(number);
            Console.WriteLine("Is Automorphic Number = " + isAutomorphic);

            // Calling method to check whether the number is Buzz
            bool isBuzz = IsBuzzNumber(number);
            Console.WriteLine("Is Buzz Number = " + isBuzz);
        }

        // Method to Check if a number is a prime number
        public static bool IsPrimeNumber(int number)
        {
            // Prime number must be greater than 1
            if (number <= 1)
            {
                return false;
            }

            // Checking divisibility from 2 to number / 2
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Method to Check if a number is a neon number
        // Neon number means sum of digits of square equals the number itself
        public static bool IsNeonNumber(int number)
        {
            // Calculating square of the number
            int square = number * number;

            int sum = 0;

            // Finding sum of digits of the square
            while (square > 0)
            {
                sum += square % 10;
                square = square / 10;
            }

            return sum == number;
        }

        // Method to Check if a number is a spy number
        // Spy number means sum of digits equals product of digits
        public static bool IsSpyNumber(int number)
        {
            int sum = 0;
            int product = 1;

            // Extracting digits and calculating sum and product
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                number = number / 10;
            }

            return sum == product;
        }

        // Method to Check if a number is an automorphic number
        // Automorphic number means square ends with the number itself
        public static bool IsAutomorphicNumber(int number)
        {
            int square = number * number;
            int temp = number;

            // Checking last digits of square with the number
            while (temp > 0)
            {
                if (square % 10 != temp % 10)
                {
                    return false;
                }
                square = square / 10;
                temp = temp / 10;
            }

            return true;
        }

        // Method to Check if a number is a buzz number
        // Buzz number is divisible by 7 or ends with 7
        public static bool IsBuzzNumber(int number)
        {
            if (number % 7 == 0 || number % 10 == 7)
            {
                return true;
            }

            return false;
        }
    }
}
