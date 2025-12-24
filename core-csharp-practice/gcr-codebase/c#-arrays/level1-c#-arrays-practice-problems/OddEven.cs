using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.arrays
{
   internal class OddEven
   {
       public static void Main(string[] args)
       {
           //Get an integer input from the user and assign it to a variable number
           int number = Convert.ToInt32(Console.ReadLine());
           //Checking for natural number it is natural number or not
           if (number >= 0)
           {
               //Printing to the statement that this number is a natural number
               Console.WriteLine("The Number" + " " + number + " " + "is a natural number");
           }
           //Checking if its not a natural number then print an error and exit the program
           else
           {
               //Printing to the statement that this number is not a natural number and exiting the code and printing the error
               Console.Error.WriteLine("The Number" + " " + number + " " + "is not a natural number");
               Environment.Exit(0);
           }
           //Creating an integer array for even with size = number / 2 + 1
           int[] evenArray = new int[(number / 2) + 1];
           //Creating an integer array for odd with size = number / 2 + 1
           int[] oddArray = new int[(number / 2) + 1];
           //Creating index variables for odd numbers and initialize them to zero
           int oddIndex = 0;
           //Create index variables for even numbers and initialize them to zero
           int evenIndex = 0;
           //Using a for loop, iterate from 1 to the number and using in each iteration of the loop 
           for (int i=1; i < number; i++)
           {
               //Checking that the number is even if its even then adding that number to the even array
               if (i % 2 == 0)
               {
                   //adding the even number to the even array with the help of even Index 
                   evenArray[evenIndex] = i;
                   //incrementing the evenIndex variable with 1
                   evenIndex++;
               }
               //Checking that the number is odd if its even then adding that number to the even array
               else if (i% 2 != 0)
               {
                   //adding the odd number to the odd array with the help of odd Index 
                   oddArray[oddIndex] = i;
                   //incrementing the oddIndex variable with 1
                   oddIndex++;
               }
           }
           //Printing the elements of the even array
           for (int i=0; i<evenArray.Length; i++)
           {
               //using if else condition to not to print 0 as array size is greater than the even number
               if (evenArray[i] != 0)
               {
                   //printing the elements of the even array that are present in the even array
                   Console.WriteLine("The elements of the even array:" + " " + evenArray[i]);
               }
           }
           //Printing the elements of the odd array
           for (int i = 0; i < oddArray.Length; i++)
           {
               //using if else condition to not to print 0 as array size is greater than the odd number
               if (oddArray[i] != 0)
               {
                   //printing the elements of the even array that are present in the even array
                   Console.WriteLine("The elements of the odd array:" + " " + oddArray[i]);
               }
           }

       }
   }
}
