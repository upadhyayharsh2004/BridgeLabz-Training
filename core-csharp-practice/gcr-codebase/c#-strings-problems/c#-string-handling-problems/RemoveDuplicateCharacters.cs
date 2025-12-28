using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class RemoveDuplicateCharacters
    {
        public static void Main()
        {
            // Ask the user to enter a string
            Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();
            // Call the function to remove duplicate characters
            string result=RemoveDuplicates(input);
            // Display the modified string
            Console.WriteLine("String after removing duplicate characters:");
            Console.WriteLine(result);
        }
        // Function to remove duplicate characters from a string
        // Parameter: string text - the original input string
        // Return type: string - string without duplicate characters
        static string RemoveDuplicates(string text)
        {
            // Variable to store the final string without duplicates
            string output="";

            // Loop through each character in the input string
            for (int i=0;i<text.Length;i++)
            {
                char currentChar=text[i];

                // Flag to check if the character already exists in output
                bool isDuplicate=false;

                // Loop through the output string to check for duplicates
                for (int j=0;j<output.Length;j++)
                {
                    if (output[j]==currentChar)
                    {
                        isDuplicate=true;
                        break;
                    }
                }

                // If the character is not a duplicate, add it to the output
                if (!isDuplicate)
                {
                    output=output+currentChar;
                }
            }

            // Return the string without duplicate characters
            return output;
        }
}
