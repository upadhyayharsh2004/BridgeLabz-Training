using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class ExtendAnotherNumberChecker
    {
        public static void Main(string[] args)
        {
            // Taking user input for the number
            int number=Convert.ToInt32(Console.ReadLine());
            // Calling method to find the count of digits in the number
            int digitCount=CountDigits(number);
            Console.WriteLine("Digit Count="+digitCount);
            // Calling method to store the digits of the number in an array
            int[] digits=StoreDigits(number,digitCount);
            // Calling method to reverse the digits array
            int[] reversedDigits = ReverseDigitsArray(digits);
            // Calling method to compare original digits array and reversed digits array
            bool areEqual=CompareArrays(digits,reversedDigits);
            Console.WriteLine("Digits and Reversed Digits are Equal="+areEqual);
            // Calling method to check whether the number is a palindrome
            bool isPalindrome=IsPalindrome(digits,reversedDigits);
            Console.WriteLine("Is Palindrome Number="+isPalindrome);
            // Calling method to check whether the number is a Duck number
            bool isDuck=IsDuckNumber(digits);
            Console.WriteLine("Is Duck Number="+isDuck);
        }
        // Method to find the count of digits in the number
        public static int CountDigits(int number)
        {
            int count=0;
            while (number!=0)
            {
                count++;
                number=number/10;
            }
            return count;
        }

        // Method to store the digits of the number in a digits array
        public static int[] StoreDigits(int number, int digitCount)
        {
            int[] digits = new int[digitCount];
            int index = 0;

            while (number != 0)
            {
                digits[index] = number % 10;
                number = number / 10;
                index++;
            }

            return digits;
        }

        // Method to reverse the digits array
        public static int[] ReverseDigitsArray(int[] digits)
        {
            int[] reversed = new int[digits.Length];
            int index = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                reversed[index] = digits[i];
                index++;
            }

            return reversed;
        }

        // Method to compare two arrays and check if they are equal
        public static bool CompareArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        // Method to check if a number is a palindrome using the digits arrays
        public static bool IsPalindrome(int[] digits, int[] reversedDigits)
        {
            return CompareArrays(digits, reversedDigits);
        }

        // Method to check if a number is a Duck number using the digits array
        // A Duck number contains at least one non-zero digit
        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
