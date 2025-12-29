using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.scenario_based
{
    internal class ParagraphAnalyzer
    {
        public static void Main(string[] args)
        {
            // Taking paragraph input from user
            Console.WriteLine("Enter a paragraph:");
            string paragraph = Console.ReadLine();

            // Check if paragraph is empty or contains only spaces
            bool hasCharacter = false;

            //Using For Loop To Check The Paragraph Is Empty Or Contains Only Spaces
            for (int i = 0; i < paragraph.Length; i++)
            {
                // Check for any non-space character
                if (paragraph[i] != ' ')
                {
                    // Found a non-space character
                    hasCharacter = true;

                    // Exit the loop early
                    break;
                }
            }
            // If no non-space character found, paragraph is empty or contains only spaces
            if (!hasCharacter)
            {
                // Paragraph is empty or contains only spaces
                Console.WriteLine("Paragraph is empty or contains only spaces.");

                // Exit the program
                return;
            }
            //Count words and find longest word
            int wordCount = 0;

            //Counting The Words And Finding The Longest Word In The Paragraph
            int currentLength = 0;

            //Finding The Maximum Length Of The Word
            int maxLength = 0;

            //Finding The Longest Word In The Paragraph
            string longestWord = "";

            // Temporary variable to build current word
            string currentWord = "";

            // Traversing through each character in the paragraph
            for (int i = 0; i < paragraph.Length; i++)
            {
                // Get current character
                char ch = paragraph[i];

                // Check if character is part of a word
                if (ch != ' ' && ch != '.' && ch != ',' && ch != '!' && ch != '?')
                {
                    // Build current word
                    currentWord += ch;

                    // Increment current word length
                    currentLength++;
                }
                else
                {
                    // End of a word
                    if (currentLength > 0)
                    {
                        // Increment word count
                        wordCount++;

                        // Check for longest word
                        if (currentLength > maxLength)
                        {
                            // Update max length and longest word
                            maxLength = currentLength;

                            // Update longest word
                            longestWord = currentWord;
                        }
                        // Reset current word and length
                        currentWord = "";

                        // Reset current length
                        currentLength = 0;
                    }
                }
            }
            // Handle last word (if paragraph does not end with space)
            if (currentLength > 0)
            {
                // Increment word count
                wordCount++;

                // Check for longest word
                if (currentLength > maxLength)
                {
                    // Update max length and longest word
                    longestWord = currentWord;
                }
            }
            // Display results
            Console.WriteLine("Word Count:"+wordCount);

            // Display longest word
            Console.WriteLine("Longest Word:"+longestWord);

            // Word replacement
            Console.WriteLine("Enter word to replace:");

            // Reading old word from user
            string oldWord = Console.ReadLine();

            // Reading new word from user
            Console.WriteLine("Enter new word:");

            // Reading new word from user
            string newWord = Console.ReadLine();

            // Reconstruct paragraph with replacements
            string result = "";

            // Reset current word
            currentWord = "";

            // Traversing through each character in the paragraph
            for (int i = 0; i < paragraph.Length; i++)
            {
                // Get current character
                char ch = paragraph[i];

                // Check if character is part of a word
                if (ch != ' ' && ch != '.' && ch != ',' && ch != '!' && ch != '?')
                {
                    // Build current word
                    currentWord += ch;
                }
                else
                {
                    // End of a word
                    if (WordsEqualIgnoreCase(currentWord, oldWord))
                    {
                        // Replace with new word
                        result += newWord;
                    }
                    else
                    {
                        // Keep original word
                        result += currentWord;
                    }

                    result += ch;
                    currentWord = "";
                }
            }
            // Handle last word replacement
            if (currentWord.Length > 0)
            {
                // End of paragraph
                if (WordsEqualIgnoreCase(currentWord, oldWord))
                {
                    // Replace with new word
                    result += newWord;
                }
                else
                {
                    // Keep original word
                    result += currentWord;
                }
            }
            // Display updated paragraph
            Console.WriteLine("Updated Paragraph:");

            // Print the result
            Console.WriteLine(result);
        }
        // Method to compare two words ignoring case
        public static bool WordsEqualIgnoreCase(string a, string b)
        {
            // If lengths differ, words are not equal
            if (a.Length != b.Length)

                // If lengths differ, words are not equal
                return false;

            // Compare characters one by one
            for (int i = 0; i < a.Length; i++)
            {
                // Get characters
                char c1 = a[i];

                // Get characters
                char c2 = b[i];

                // Convert uppercase to lowercase manually
                if (c1 >= 'A' && c1 <= 'Z')

                    // Convert to lowercase
                    c1 = (char)(c1 + 32);

                // Convert uppercase to lowercase manually
                if (c2>='A'&&c2<='Z')

                    // Convert to lowercase
                    c2 = (char)(c2+32);

                // If characters differ, words are not equal
                if (c1!=c2)

                    // Words are not equal
                    return false;
            }
            // Words are equal
            return true;
        }
    }
}
