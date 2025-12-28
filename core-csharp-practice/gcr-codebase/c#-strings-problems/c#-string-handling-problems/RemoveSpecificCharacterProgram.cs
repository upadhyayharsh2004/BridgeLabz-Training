using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class RemoveSpecificCharacterProgram
    {
        public static void Main()
        {
            // Ask the user to enter a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            // Ask the user to enter the character to remove
            Console.WriteLine("Enter the character to remove:");
            char removeChar = Console.ReadLine()[0];
            // Call the function to remove the specific character
            string result = RemoveCharacter(input, removeChar);
            // Display the modified string
            Console.WriteLine("Modified String:");
            Console.WriteLine(result);
        }
        // Function to remove all occurrences of a specific character from a string
        // Parameters:
        // string text - the original string
        // char ch - the character to remove
        // Return type: string - modified string after removal
        static string RemoveCharacter(string text, char ch)
        {
            // Variable to store the final modified string
            string output = "";

            // Loop through each character in the string
            for (int i = 0; i < text.Length; i++)
            {
                // Add character to output only if it does not match the remove character
                if (text[i] != ch)
                {
                    output = output + text[i];
                }
            }

            // Return the modified string
            return output;
        }
    }
}
