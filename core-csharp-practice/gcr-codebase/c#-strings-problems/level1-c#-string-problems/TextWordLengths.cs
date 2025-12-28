using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class TextWordLengths
    {
        public static void Main()
        {
            // Take user input
            Console.Write("Enter a sentence: ");
            string input=Console.ReadLine();
            // Get 2D array of words and lengths
            string[,] result = SplitWordsAndLengths(input);
            // Display result
            Console.WriteLine("\nWord\tLength");
            Console.WriteLine("--------------");
            for (int i=0;i<result.GetLength(0); i++)
            {
                Console.WriteLine(result[i,0]+"\t"+result[i, 1]);
            }
        }
        // Method to split text into words and return 2D array
        static string[,] SplitWordsAndLengths(string text)
        {
            List<string>words=new List<string>();
            string currentWord="";
            // Split without using string.Split()
            for (int i=0;i<GetStringLength(text);i++)
            {
                if (text[i]!=' ')
                {
                    currentWord+=text[i];
                }
                else
                {
                    if (currentWord!="")
                    {
                        words.Add(currentWord);
                        currentWord="";
                    }
                }
            }
            // Add last word
            if(currentWord!="")
            {
                words.Add(currentWord);
            }
            // Create 2D array
            string[,]result=new string[words.Count,2];
            for (int i=0;i<words.Count;i++)
            {
                result[i,0]=words[i];
                result[i,1]=GetStringLength(words[i]).ToString();
            }
            return result;
        }
        // Method to calculate string length without using string.Length
        static int GetStringLength(string str)
        {
            int count=0;
            foreach(char c in str)
            {
                count++;
            }
            return count;
        }
    }
}
