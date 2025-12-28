using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class FormatExceptionProblems
    {
        public static void Main()
        {
            DemonstrateFormatException();
        }
        // Method to demonstrate FormatException
        static void DemonstrateFormatException()
        {
            string value="abc";//Non-numeric string
            try
            {
                // Attempt to convert non-numeric string to int
                int number=int.Parse(value);
                Console.WriteLine("Number:"+number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException caught!");
                Console.WriteLine("Message:"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution continues...");
            }
        }
    }
}
