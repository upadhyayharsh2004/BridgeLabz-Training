using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class LongestWordFinder
    {
        public static void Main()
        {
            // Ask the user to enter a sentence
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            // Call the function to find the longest word
            string longestWord = FindLongestWord(sentence);
            // Display the longest word
            Console.WriteLine("The longest word in the sentence is:");
            Console.WriteLine(longestWord);
        }
        // Function to find the longest word in a sentence
        // Parameter: string text - the input sentence
        // Return type: string - the longest word
        static string FindLongestWord(string text)
        {
            // Variable to store the current word being processed
            string currentWord = "";
            // Variable to store the longest word found
            string longestWord = "";
            // Loop through each character in the sentence
            for (int i = 0; i < text.Length; i++)
            {
                // If the character is not a space, add it to the current word
                if (text[i] != ' ')
                {
                    currentWord = currentWord + text[i];
                }
                else
                {
                    // Compare lengths when a space is found
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord;
                    }

                    // Reset current word for the next word
                    currentWord = "";
                }
            }
            // Check the last word after the loop ends
            if (currentWord.Length > longestWord.Length)
            {
                longestWord=currentWord;
            }
            // Return the longest word
            return longestWord;
        }
    }
}
