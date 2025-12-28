using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class LowerToUpper
    {
        public static void Main()
        {
            // Take user input
            Console.Write("Enter a string: ");
            string input=Console.ReadLine();
            // Convert using ASCII logic
            string customUpper=ConvertToUpperUsingAscii(input);
            // Convert using built-in method
            string builtInUpper=input.ToUpper();
            // Display results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Using ASCII logic:"+ customUpper);
            Console.WriteLine("Using ToUpper():"+builtInUpper);
            Console.WriteLine("Are both equal?:"+customUpper.Equals(builtInUpper));
        }
        // Method to convert string to uppercase using ASCII logic
        static string ConvertToUpperUsingAscii(string str)
        {
            char[]chars=new char[str.Length];
            for (int i=0;i<str.Length;i++)
            {
                char c=str[i];
                // ASCII logic: a–z → A–Z
                if (c>='a'&&c<='z')
                {
                    chars[i]=(char)(c-32);
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
