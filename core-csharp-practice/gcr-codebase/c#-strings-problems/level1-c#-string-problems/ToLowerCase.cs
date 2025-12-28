using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class ToLowerCase
    {
        public static void Main()
        {
            // Take user input
            Console.Write("Enter a string: ");
            string input=Console.ReadLine();
            // Convert using ASCII logic
            string customLower=ConvertToLowerUsingAscii(input);
            // Convert using built-in method
            string builtInLower=input.ToLower();
            // Display results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Using ASCII logic:"+customLower);
            Console.WriteLine("Using ToLower():"+builtInLower);
            Console.WriteLine("Are both equal? :"+customLower.Equals(builtInLower));
        }
        // Method to convert string to lowercase using ASCII logic
        static string ConvertToLowerUsingAscii(string str)
        {
            char[] chars=new char[str.Length];
            for (int i=0;i<str.Length;i++)
            {
                char c=str[i];
                // ASCII logic: A–Z → a–z
                if (c >='A'&&c<='Z')
                {
                    chars[i]=(char)(c+32);
                }
                else
                {
                    chars[i]=c;
                }
            }
            return new string(chars);
        }
    }
}
