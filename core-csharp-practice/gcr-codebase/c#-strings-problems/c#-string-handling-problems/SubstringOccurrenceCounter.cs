using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class SubstringOccurrenceCounter
    {
        public static void Main()
        {
            // Ask the user to enter the main string
            Console.WriteLine("Enter the main string:");
            string mainString = Console.ReadLine();
            // Ask the user to enter the substring to search for
            Console.WriteLine("Enter the substring to find:");
            string subString = Console.ReadLine();
            // Call the function to count substring occurrences
            int count = CountSubstringOccurrences(mainString, subString);
            // Display the result
            Console.WriteLine("The substring occurs " + count + "time(s).");
        }
        // Function to count occurrences of a substring in a string
        // Parameters:
        // string text - the main string
        // string pattern - the substring to search for
        // Return type: int - number of occurrences
        static int CountSubstringOccurrences(string text, string pattern)
        {
            // Variable to store the count of occurrences
            int count = 0;

            // If the substring is empty, return 0
            if (pattern.Length == 0)
            {
                return 0;
            }

            // Loop through the main string
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                // Flag to check if substring matches
                bool matchFound = true;
                // Compare substring characters one by one
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        matchFound = false;
                        break;
                    }
                }
                // If a match is found, increase the count
                if (matchFound)
                {
                    count++;
                }
            }
            // Return the total count
            return count;
        }
    }
}
