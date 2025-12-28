using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class ExceptionIndex
    {
        public static void Main()
        {
            GenerateIndexOutOfRangeException();
            HandleIndexOutOfRangeException();
        }
        // Method to generate IndexOutOfRangeException
        static void GenerateIndexOutOfRangeException()
        {
            string text="Hello";
            // Accessing invalid index
            // Valid indexes: 0 to 4
            char ch=text[10]; // Causes IndexOutOfRangeException
            Console.WriteLine(ch);
        }
        // Method to handle IndexOutOfRangeException
        static void HandleIndexOutOfRangeException()
        {
            string text="World";
            try
            {
                // Invalid index access
                char ch = text[8];
                Console.WriteLine("Character:"+ch);
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
