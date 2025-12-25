using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class QuotientAndRemainder
   {
       public static void Main(string[] args)
       {
           //Taking user input for 2 number for doing operation of quotient and remainder
           int firstNumber = Convert.ToInt32(Console.ReadLine());
           int secondNumber = Convert.ToInt32(Console.ReadLine());
           //Calling a method to find quotient and remainder between 2 number and storing it in array to print further
           int[]checkedArray = FindRemainderAndQuotient(firstNumber, secondNumber);
           Console.WriteLine("The Quotient and Remanider of the 2 number" + " " + firstNumber + " " + "and" +" "+ secondNumber + " " + "is" + " " + checkedArray[0] + " " + "and" +" "+ checkedArray[1]);
       }
       public static int[] FindRemainderAndQuotient(int number, int divisor)
       {
           int[] array = new int[2];
           int quotient = number / divisor;
           int remainder = number % divisor;
           array[0] = quotient;
           array[1] = remainder;
           return array;
       }
   }
}
