using System;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class NumberCheckProgram
    {
        public static void Main(string[] args)
        {
            // Creating an array of size 5 to store the numbers
            int[] numbers = new int[5];
            // Taking user input for 5 numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Loop through the array and check each number
            for (int i = 0; i < numbers.Length; i++)
            {
                // Checking whether the number is positive or negative
                bool isPositive = IsPositive(numbers[i]);
                if (isPositive)
                {
                    // If the number is positive, check whether it is even or odd
                    bool isEven = IsEven(numbers[i]);
                    if (isEven)
                    {
                        Console.WriteLine(numbers[i] + "is Positive and Even");
                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + "is Positive and Odd");
                    }
                }
                else
                {
                    // If the number is negative, print negative
                    Console.WriteLine(numbers[i] + "is Negative");
                }
            }
            // Comparing the first and last elements of the array
            int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
            // Displaying the comparison result
            if (comparisonResult == 1)
            {
                Console.WriteLine("First number is greater than last number");
            }
            else if (comparisonResult == 0)
            {
                Console.WriteLine("First number is equal to last number");
            }
            else
            {
                Console.WriteLine("First number is less than last number");
            }
        }
        // Method to check whether the number is positive or negative
        public static bool IsPositive(int number)
        {
            if (number >= 0)
            {
                return true;
            }
            return false;
        }
        // Method to check whether the number is even or odd
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        // Method to compare two numbers
        // Return 1 if number1 > number2
        // Return 0 if both are equal
        // Return -1 if number1 < number2
        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 == number2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
