using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class ArgumentException
    {
        public static void Main()
        {
            DemonstrateArgumentOutOfRangeException();
        }
        // Method to demonstrate ArgumentOutOfRangeException
        static void DemonstrateArgumentOutOfRangeException()
        {
            string text="Programming";
            try
            {
                // Invalid usage of Substring
                // Start index = 8, length = 10 (goes beyond string length)
                string result=text.Substring(8,10);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ArgumentOutOfRangeException caught!");
                Console.WriteLine("Message:"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution continues...");
            }
        }
    }
}
