using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class ToggleCaseProgram
    {
        public static void Main()
        {
            // Ask the user to enter a string
            Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();
            // Call the function to toggle the case of characters
            string result=ToggleCase(input);
            // Display the toggled string
            Console.WriteLine("String after toggling case:");
            Console.WriteLine(result);
        }
        // Function to toggle the case of each character in a string
        // Parameter: string text - the original input string
        // Return type: string - string with toggled case
        static string ToggleCase(string text)
        {
            // Variable to store the final toggled string
            string output="";
            // Loop through each character in the string
            for (int i=0;i<text.Length;i++)
            {
                char ch=text[i];
                // Check if the character is an uppercase letter
                if (ch >='A'&&ch<='Z')
                {
                    // Convert uppercase to lowercase
                    output=output+(char)(ch + 32);
                }
                // Check if the character is a lowercase letter
                else if (ch >='a'&&ch<='z')
                {
                    // Convert lowercase to uppercase
                    output=output+(char)(ch - 32);
                }
                else
                {
                    // If character is not a letter, keep it unchanged
                    output=output+ch;
                }
            }
            // Return the toggled string
            return output;
        }
    }
}
