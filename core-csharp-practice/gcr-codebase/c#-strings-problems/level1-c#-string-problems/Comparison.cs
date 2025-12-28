using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class Comparison
    {
        public static void Main()
        {
            // Take user input
            Console.Write("Enter first string:");
            string str1=Console.ReadLine();
            Console.Write("Enter second string:");
            string str2=Console.ReadLine();
            // Compare using custom method
            bool charCompareResult=CompareUsingCharAt(str1,str2);
            // Compare using built-in method
            bool builtInResult=string.Equals(str1,str2);
            // Display results
            Console.WriteLine("\nComparison Results:");
            Console.WriteLine("Using CharAt logic:"+charCompareResult);
            Console.WriteLine("Using string.Equals():"+builtInResult);
        }
        // Method to compare strings using charAt logic
        static bool CompareUsingCharAt(string s1,string s2)
        {
            // Check length first
            if (s1.Length!=s2.Length)
            {
                return false;
            }
            // Compare each character
            for (int i=0;i<s1.Length;i++)
            {
                if (s1[i]!=s2[i])
                    return false;
            }
            return true;
        }
    }
}
