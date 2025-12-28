using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__string_problems
{
    internal class ExceptionHandling
    {
        public static void Main()
        {
            DemonstrateNullReferenceException();
        }
        // Method to demonstrate NullReferenceException
        static void DemonstrateNullReferenceException()
        {
            string message=null;//null string
            try
            {
                // Attempt to access a method on a null object
                int length=message.Length;//Causes NullReferenceException
                Console.WriteLine("Length:"+length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException caught!");
                Console.WriteLine("Message:"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution continues...");
            }
        }
    }
}
