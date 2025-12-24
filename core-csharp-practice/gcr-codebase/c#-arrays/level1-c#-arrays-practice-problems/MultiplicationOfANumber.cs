using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays
{
   internal class MultiplicationOfANumber
   {
       public static void Main(string[] args)
       {
           //Get an integer input and store it in the number variable.
           int number = Convert.ToInt32(Console.ReadLine());
           //Declaring an array with the size of 10 to store multiplication table values
           int[] multiplicationResult = new int[4];
           //Intializing the variable i with the initial value 0
           int index = 0;
           //Using for loop to iterate through the array to store multiplication table values from 6 to 9 number entered by the user
           for (int i = 6; i <= 9; i++)
           {
               //Storing multiplication table values in the array
               multiplicationResult[index] = number * i;
               //Increasing index by 1 to store each multiplication valued in the array
               index++;
           }
           //Intializing the variable index with the initial value 0
           index = 0;
           //Using for loop to print the outputed multiplication table of an number inputted by the user
           for (int i = 6; i <= 9; i++)
           {
               //Printing the multiplication of a number in form of a table
               Console.WriteLine(number + "*" + i + "=" + multiplicationResult[index]);
               index++;
           }
       }
   }
}


