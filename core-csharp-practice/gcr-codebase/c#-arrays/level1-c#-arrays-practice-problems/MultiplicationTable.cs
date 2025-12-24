using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays
{
   internal class MultiplicationTable
   {
       public static void Main(string[] args)
       {
           //Get an integer input and store it in the number variable.
           int number = Convert.ToInt32(Console.ReadLine());
           //Declaring an array with the size of 10 to store multiplication table values
           int[] multi = new int[10];
           //Using for loop to iterate through the array to store multiplication table values
           for (int i = 1; i < 10; i++)
           {
               //Storing multiplication table values in the array
               multi[i] = number * i;
               //Printing the multiplication of a number in form of a table
               Console.WriteLine(number + "*" + i + "=" + multi[i]);
           }
       }
   }
}
