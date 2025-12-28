using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.c__strings_problems.extras_c__strings_problems
{
    internal class AnagramCheckProgram
    {
        static void Main()
        {
            // Ask the user to enter the first string
            Console.WriteLine("Enter first string:");
            string str1=Console.ReadLine();
            // Ask the user to enter the second string
            Console.WriteLine("Enter second string:");
            string str2=Console.ReadLine();
            // Call the function to check if the strings are anagrams
            bool result=CheckAnagram(str1,str2);
            // Display the result
            if(result)
            {
                Console.WriteLine("The given strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The given strings are not anagrams.");
            }
        }
        //Function to check whether two strings are anagrams
        //Parameters:
        //string text1-first input string
        //string text2-second input string
        //Return type:bool-true if anagrams, false otherwise
        static bool CheckAnagram(string text1,string text2)
        {
            // If lengths are not equal, strings cannot be anagrams
            if(text1.Length!=text2.Length)
            {
                return false;
            }
            // Convert both strings to lowercase for case-insensitive comparison
            text1=text1.ToLower();
            text2=text2.ToLower();
            // Array to store character count (assuming only lowercase English letters)
            int[]charCount=new int[26];
            // Count characters from the first string
            for (int i=0;i<text1.Length;i++)
            {
                charCount[text1[i]-'a']++;
            }
            // Subtract character counts using the second string
            for (int i=0;i<text2.Length;i++)
            {
                charCount[text2[i]-'a']--;
            }
            // Check if all counts are zero
            for(int i=0;i<26;i++)
            {
                if (charCount[i]!=0)
                {
                    return false;
                }
            }
            // If all character counts match, strings are anagrams
            return true;
        }
    }
}
