using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class MostFrequentCharacterProgram
    {
        public static void Main()
        {
            // Ask the user to enter a string
            Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();
            // Call the function to find the most frequent character
            char result=FindMostFrequentCharacter(input);
            // Display the most frequent character
            Console.WriteLine("Most Frequent Character:'"+result+"'");
        }
        // Function to find the most frequent character in a string
        // Parameter: string text - the input string
        // Return type: char - the most frequent character
        static char FindMostFrequentCharacter(string text)
        {
            // Variable to store the maximum frequency found
            int maxCount=0;
            // Variable to store the most frequent character
            char mostFrequent='\0';
            // Loop through each character in the string
            for(int i=0;i<text.Length;i++)
            {
                char currentChar=text[i];
                int count=0;
                // Count occurrences of the current character
                for(int j=0;j<text.Length;j++)
                {
                    if (text[j]==currentChar)
                    {
                        count++;
                    }
                }
                // Update the most frequent character if needed
                if(count>maxCount)
                {
                    maxCount=count;
                    mostFrequent=currentChar;
                }
            }
            // Return the most frequent character
            return mostFrequent;
        }
    }
}
