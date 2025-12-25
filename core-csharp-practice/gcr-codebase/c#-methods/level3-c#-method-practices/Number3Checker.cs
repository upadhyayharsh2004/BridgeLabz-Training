using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class Number3Checker
    {
        public static void Main(string[] args)
        {
            // Taking user input for the number
            int number = Convert.ToInt32(Console.ReadLine());

            // Calling method to find all factors of the number
            int[] factors = FindFactors(number);

            // Displaying the factors
            Console.WriteLine("Factors of the number:");
            for (int i = 0; i < factors.Length; i++)
            {
                Console.Write(factors[i] + " ");
            }
            Console.WriteLine();

            // Calling method to find the greatest factor
            int greatestFactor = FindGreatestFactor(factors);
            Console.WriteLine("Greatest Factor = " + greatestFactor);

            // Calling method to find the sum of factors
            int sumOfFactors = SumOfFactors(factors);
            Console.WriteLine("Sum of Factors = " + sumOfFactors);

            // Calling method to find the product of factors
            long productOfFactors = ProductOfFactors(factors);
            Console.WriteLine("Product of Factors = " + productOfFactors);

            // Calling method to find the product of cube of factors
            double cubeProduct = ProductOfCubeOfFactors(factors);
            Console.WriteLine("Product of Cube of Factors = " + cubeProduct);

            // Calling method to check whether the number is a perfect number
            bool isPerfect = IsPerfectNumber(number, factors);
            Console.WriteLine("Is Perfect Number = " + isPerfect);

            // Calling method to check whether the number is an abundant number
            bool isAbundant = IsAbundantNumber(number, factors);
            Console.WriteLine("Is Abundant Number = " + isAbundant);

            // Calling method to check whether the number is a deficient number
            bool isDeficient = IsDeficientNumber(number, factors);
            Console.WriteLine("Is Deficient Number = " + isDeficient);

            // Calling method to check whether the number is a strong number
            bool isStrong = IsStrongNumber(number);
            Console.WriteLine("Is Strong Number = " + isStrong);
        }

        // Method to find factors of a number and return them as an array
        public static int[] FindFactors(int number)
        {
            // First loop to count the number of factors
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            // Creating array to store factors
            int[] factors = new int[count];
            int index = 0;

            // Second loop to find factors and store them in the array
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }

        // Method to find the greatest factor of a number using the factors array
        public static int FindGreatestFactor(int[] factors)
        {
            int greatest = factors[0];
            for (int i = 1; i < factors.Length; i++)
            {
                if (factors[i] > greatest)
                {
                    greatest = factors[i];
                }
            }
            return greatest;
        }

        // Method to find the sum of the factors using factors array
        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }

        // Method to find the product of the factors using factors array
        public static long ProductOfFactors(int[] factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }

        // Method to find product of cube of the factors using the factors array
        public static double ProductOfCubeOfFactors(int[] factors)
        {
            double product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= Math.Pow(factors[i], 3);
            }
            return product;
        }

        // Method to check if a number is a perfect number
        public static bool IsPerfectNumber(int number, int[] factors)
        {
            int sum = 0;

            // Proper divisors exclude the number itself
            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] != number)
                {
                    sum += factors[i];
                }
            }

            return sum == number;
        }

        // Method to check if a number is an abundant number
        public static bool IsAbundantNumber(int number, int[] factors)
        {
            int sum = 0;

            // Sum of proper divisors
            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] != number)
                {
                    sum += factors[i];
                }
            }

            return sum > number;
        }

        // Method to check if a number is a deficient number
        public static bool IsDeficientNumber(int number, int[] factors)
        {
            int sum = 0;

            // Sum of proper divisors
            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] != number)
                {
                    sum += factors[i];
                }
            }

            return sum < number;
        }

        // Method to check if a number is a strong number
        // Strong number means sum of factorial of digits equals the number
        public static bool IsStrongNumber(int number)
        {
            int temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += Factorial(digit);
                temp = temp / 10;
            }

            return sum == number;
        }

        // Method to find factorial of a digit
        public static int Factorial(int digit)
        {
            int fact = 1;
            for (int i = 1; i <= digit; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
