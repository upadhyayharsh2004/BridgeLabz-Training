using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class StringComparisonProgram
    {
        public static void Main()
        {
            // Ask the user to enter the first string
            Console.WriteLine("Enter first string:");
            string str1=Console.ReadLine();
            // Ask the user to enter the second string
            Console.WriteLine("Enter second string:");
            string str2=Console.ReadLine();
            // Call the function to compare the two strings
            CompareStrings(str1,str2);
        }
        // Function to compare two strings lexicographically
        // Parameters:
        // string first - first input string
        // string second - second input string
        // Return type: void (result is displayed inside the function)
        static void CompareStrings(string first, string second)
        {
            // Find the minimum length of the two strings
            int minLength=first.Length<second.Length?first.Length:second.Length;
            // Loop through each character up to the minimum length
            for (int i=0;i<minLength;i++)
            {
                // Compare characters at the current position
                if (first[i]<second[i])
                {
                    Console.WriteLine("\""+first+"\"comes before\""+second+"\"in lexicographical order");
                    return;
                }
                else if (first[i]>second[i])
                {
                    Console.WriteLine("\""+first+"\"comes after\""+second+"\"in lexicographical order");
                    return;
                }
            }
            // If all compared characters are equal, compare lengths
            if (first.Length<second.Length)
            {
                Console.WriteLine("\""+first+"\"comes before\""+second+"\"in lexicographical order");
            }
            else if (first.Length>second.Length)
            {
                Console.WriteLine("\""+first+"\"comes after\""+second+"\"in lexicographical order");
            }
            else
            {
                // If lengths and characters are equal, strings are the same
                Console.WriteLine("Both strings are equal");
            }
        }
    }
}
