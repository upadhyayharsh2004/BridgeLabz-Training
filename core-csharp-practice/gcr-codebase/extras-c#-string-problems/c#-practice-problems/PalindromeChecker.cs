using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class PalindromeChecker
    {
        public static void Main()
        {
            // Get the input string from the user
            string input=GetInputString();
            // Check whether the string is a palindrome
            bool result = IsPalindrome(input);
            // Display the result
            DisplayResult(input, result);
        }
        // Function to take string input from the user
        // Return type: string - input entered by the user
        static string GetInputString()
        {
            Console.WriteLine("Enter a string:");
            string text=Console.ReadLine();
            return text;
        }
        // Function to check if a string is a palindrome
        // Parameter: string text-input string
        // Return type:bool-true if palindrome,false otherwise
        static bool IsPalindrome(string text)
        {
            // Convert the string to lowercase to ignore case differences
            text=text.ToLower();
            // Get the length of the string
            int length=text.Length;
            // Compare characters from start and end
            for (int i=0;i<length/2;i++)
            {
                if (text[i]!=text[length-1-i])
                {
                    return false;
                }
            }
            // If all characters match, it is a palindrome
            return true;
        }
        // Function to display the result
        // Parameters:
        // string text-input string
        // bool isPalindrome - result of palindrome check
        static void DisplayResult(string text,bool isPalindrome)
        {
            if(isPalindrome)
            {
                Console.WriteLine("The given string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The given string is not a palindrome.");
            }
        }
    }
}
