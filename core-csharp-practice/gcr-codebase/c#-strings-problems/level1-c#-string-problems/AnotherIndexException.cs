using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class AnotherIndexException
    {
        public static void Main()
        {
            DemonstrateArrayIndexOutOfRangeException();
        }
        // Method to demonstrate IndexOutOfRangeException for arrays
        static void DemonstrateArrayIndexOutOfRangeException()
        {
            int[] numbers = {10,20,30,40,50};
            try
            {
                // Invalid index access
                // Valid indexes:0 to 4
                int value=numbers[7]; // Causes IndexOutOfRangeException
                Console.WriteLine("Value:"+value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught!");
                Console.WriteLine("Message:"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution continues...");
            }
        }
    }
}
