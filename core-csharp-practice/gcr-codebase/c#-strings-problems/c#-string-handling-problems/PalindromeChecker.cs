using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class PalindromeChecker
    {
        public static void Main()
        {
            // Ask the user to enter a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            // Call the function to check whether the string is a palindrome
            bool isPalindrome = CheckPalindrome(input);
            // Display the result
            if (isPalindrome)
            {
                Console.WriteLine("The given string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The given string is not a palindrome.");
            }
        }
        // Function to check if a string is a palindrome
        // Parameter: string text - the input string
        // Return type: bool - true if palindrome, false otherwise
        static bool CheckPalindrome(string text)
        {
            // Convert the string to lowercase to ignore case differences
            text = text.ToLower();
            // Get the length of the string
            int length = text.Length;
            // Loop from the start to the middle of the string
            for (int i = 0; i < length / 2; i++)
            {
                // Compare characters from beginning and end
                if (text[i] != text[length - 1 - i])
                {
                    // If characters do not match, it is not a palindrome
                    return false;
                }
            }
            // If all characters match, it is a palindrome
            return true;
        }
    }
}
