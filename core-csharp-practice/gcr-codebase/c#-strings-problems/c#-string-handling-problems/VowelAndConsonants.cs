using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class VowelAndConsonants
    {
        public static void Main()
        {
            // Ask the user to enter a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            // Call the function to count vowels and consonants
            CountVowelsAndConsonants(input);
        }
        // Function to count vowels and consonants in a string
        // Parameter: string text - the input string entered by the user
        // Return type: void (results are displayed inside the function)
        static void CountVowelsAndConsonants(string text)
        {
            // Variable to store number of vowels
            int vowelCount = 0;
            // Variable to store number of consonants
            int consonantCount = 0;
            // Convert the string to lowercase to simplify comparison
            text = text.ToLower();
            // Loop through each character in the string
            foreach (char ch in text)
            {
                // Check if the character is an alphabet
                if (char.IsLetter(ch))
                {
                    // Check if the character is a vowel
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        // If it is a letter but not a vowel, it is a consonant
                        consonantCount++;
                    }
                }
            }
            // Display the results
            Console.WriteLine("Number of vowels:" + vowelCount);
            Console.WriteLine("Number of consonants:" + consonantCount);
        }
    }
}