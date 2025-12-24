using System;

namespace BridgeLabzTraining.arrays
{
   internal class FactorsNumber
   {
       public static void Main(string[] args)
       {
           // Get an integer input from the user and assign it to a variable number
           int number = Convert.ToInt32(Console.ReadLine());
           // Create integer variable maxFactor and initialize to 10
           int maxFactor = 10;
           // Creating a factors array of size maxFactor
           int[] factors = new int[maxFactor];
           // Creating an index variable to reflect the index of the array
           int index = 0;
           // To find factors loop through the numbers from 1 to the number
           for (int i = 1; i <= number; i++)
           {
               if (number % i == 0)
               {
                   // If index is equal to maxFactor, increase array size
                   if (index == maxFactor)
                   {
                       // Reset maxFactor to twice its size
                       maxFactor = maxFactor * 2;
                       // Create temp array with new size
                       int[] temp = new int[maxFactor];
                       // Copy old elements into temp array
                       for (int j = 0; j < factors.Length; j++)
                       {
                           temp[j] = factors[j];
                       }
                       // Assign factors array to temp array
                       factors = temp;
                   }
                   // Add factor to array
                   factors[index] = i;
                   index++;
               }
           }
           // Display the factors of the number
           for (int i = 0; i < index; i++)
           {
               Console.Write(factors[i] + " ");
           }
       }
   }
}
