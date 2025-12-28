using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class Substring
    {
        public static void Main()
        {
            // Take user input
            Console.Write("Enter a string:");
            string input=Console.ReadLine();
            Console.Write("Enter start index: ");
            int startIndex=int.Parse(Console.ReadLine());
            Console.Write("Enter end index:");
            int endIndex=int.Parse(Console.ReadLine());
            // Create substring using charAt logic
            string charAtSubstring = CreateSubstringUsingCharAt(input,startIndex,endIndex);
            // Create substring using built-in method
            string builtInSubstring=input.Substring(startIndex,endIndex-startIndex);
            // Display results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Substring using charAt logic:"+charAtSubstring);
            Console.WriteLine("Substring using Substring():"+builtInSubstring);
            Console.WriteLine("Are both substrings equal?:"+charAtSubstring.Equals(builtInSubstring));
        }
        // Method to create substring using charAt logic
        static string CreateSubstringUsingCharAt(string str,int start,int end)
        {
            string result="";
            for (int i=start;i<end;i++)
            {
                result+=str[i];
            }
            return result;
        }
    }
}
