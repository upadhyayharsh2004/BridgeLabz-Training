using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class ReverseString
    {
        public static void Main()
        {
            // Ask the user to enter a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            // Call the function to reverse the string
            string reversedString = ReverseStringProgram(input);
            // Display the reversed string
            Console.WriteLine("Reversed string:" + reversedString);
        }
        // Function to reverse a string without using built-in reverse methods
        // Parameter: string text - the original string
        // Return type: string - the reversed string
        static string ReverseStringProgram(string text)
        {
            // Variable to store the reversed string
            string result = "";
            // Loop through the string from last character to first
            for (int i=text.Length-1;i >= 0;i--)
            {
                // Add each character to the result string
                result=result+text[i];
            }
            // Return the reversed string
            return result;
        }
    }
}
