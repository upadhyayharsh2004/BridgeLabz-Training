using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class ComparisonOfCharacter
    {
        public static void Main()
        {
            // Take user input
            Console.Write("Enter a string: ");
            string input=Console.ReadLine();
            // Get characters using custom method
            char[] customChars=GetCharactersWithoutToCharArray(input);
            // Get characters using built-in method
            char[] builtInChars = input.ToCharArray();
            // Display results
            Console.WriteLine("\nCharacters using custom method:");
            DisplayCharacters(customChars);
            Console.WriteLine("\nCharacters using ToCharArray():");
            DisplayCharacters(builtInChars);
            // Compare both results
            Console.WriteLine("\nAre both character arrays equal?"+AreCharArraysEqual(customChars,builtInChars));
        }
        // Method to return characters without using ToCharArray()
        static char[] GetCharactersWithoutToCharArray(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                chars[i] = str[i]; // charAt logic
            }
            return chars;
        }
        // Method to display characters
        static void DisplayCharacters(char[]chars)
        {
            foreach (char c in chars)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
        // Method to compare two char arrays
        static bool AreCharArraysEqual(char[] a,char[] b)
        {
            if (a.Length!=b.Length)
            {
                return false;
            }   
            for (int i=0;i<a.Length;i++)
            {
                if (a[i]!=b[i])
                    return false;
            }
            return true;
        }
    }
}
