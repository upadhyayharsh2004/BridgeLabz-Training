using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays
{
   internal class NumberChecker
   {
       public static void Main(string[] args)
       {
           //Declaring an array with the size of 5 to store numbers for checking of positive and negative or zero
           int[] number = new int[5];
           //Using for loop to take user input for the numbers
           for (int i = 0; i < number.Length; i++)
           {
               //Taking user input for checking positive, negative or zero
               number[i] = Convert.ToInt32(Console.ReadLine());
           }
           //Using for loop to iterate through the array for checking positive, negative or zero
           for (int i = 0; i < number.Length; i++)
           {
               //Using if else condition to check whether the number is positive
               if (number[i] >= 0)
               {
                   //using if else condition to check whether the number is even or odd
                   if (number[i] % 2 == 0)
                   {
                       //Printing that the number is positive even number
                       Console.WriteLine("The number" + " " + number[i] + " " + "is positive even number.");
                   }
                   else
                   {
                       //Printing that the number is positive odd number
                       Console.WriteLine("The number" + " " + number[i] + " " + "is positive odd number.");

                   }
               }
               else if (number[i] < 0)
               {
                   //Printing that the number is negative number
                   Console.WriteLine("The number" + " " + number[i] + " " + "is negative number.");

               }
               else
               {
                   //Printing that the number is zero
                   Console.WriteLine("The number is zero.");
               }
               //Comparing the first and last elements of the array to check which is greater lesser and equal
           }
           if (number[0] == number[4])
           {
               //Printing that both numbers are equal
               Console.WriteLine("Both numbers are equal.");
           }
           else if (number[0] > number[4])
           {
               //Printing that the first number is greater than the last number
               Console.WriteLine("The first number is greater than the last number.");
           }
           else
           {
               //Printing that the last number is greater than the first number
               Console.WriteLine("The last number is greater than the first number.");
           }
       }
   }
}
