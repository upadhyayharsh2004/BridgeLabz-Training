using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class ReplaceWordProgram
    {
        public static void Main()
        {
            // Ask the user to enter a sentence
            Console.WriteLine("Enter a sentence:");
            string sentence=Console.ReadLine();
            // Ask the user to enter the word to be replaced
            Console.WriteLine("Enter the word to replace:");
            string oldWord=Console.ReadLine();
            // Ask the user to enter the new word
            Console.WriteLine("Enter the new word:");
            string newWord=Console.ReadLine();
            // Call the replace method
            string result = ReplaceWord(sentence,oldWord,newWord);
            // Display the modified sentence
            Console.WriteLine("Modified sentence:");
            Console.WriteLine(result);
        }
        // Method to replace a given word with another word in a sentence
        // Parameters:
        // string text - the original sentence
        // string oldWord - the word to be replaced
        // string newWord - the word to replace with
        // Return type: string - modified sentence
        static string ReplaceWord(string text,string oldWord,string newWord)
        {
            // Variable to store the final modified sentence
            string result="";
            // Loop through the sentence character by character
            for (int i=0;i<text.Length;)
            {
                bool matchFound=true;
                // Check if oldWord matches starting at current position
                if(i+oldWord.Length<=text.Length)
                {
                    for(int j=0;j<oldWord.Length; j++)
                    {
                        if(text[i+j]!=oldWord[j])
                        {
                            matchFound=false;
                            break;
                        }
                    }
                }
                else
                {
                    matchFound=false;
                }

                // If match is found, add newWord to result
                if(matchFound)
                {
                    result=result + newWord;
                    i=i+oldWord.Length;
                }
                else
                {
                    // Otherwise, copy the current character
                    result=result+text[i];
                    i++;
                }
            }
            // Return the modified sentence
            return result;
        }
    }
}
