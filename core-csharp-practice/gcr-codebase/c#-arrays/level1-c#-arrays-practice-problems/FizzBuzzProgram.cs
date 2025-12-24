using System;

namespace BridgeLabzTraining.arrays
{
   internal class FizzBuzzProgram
   {
       public static void Main(string[] args)
       {
           // Take a number as user input
           int number = Convert.ToInt32(Console.ReadLine());

           // Check if the number is a positive integer
           if (number > 0)
           {
               // Create a String Array to save the results
               string[] result = new string[number + 1];

               // Loop from 1 to the number and save Fizz, Buzz, FizzBuzz or the number
               for (int i = 1; i <= number; i++)
               {
                   if (i % 3 == 0 && i % 5 == 0)
                   {
                       result[i] = "FizzBuzz";
                   }
                   else if (i % 3 == 0)
                   {
                       result[i] = "Fizz";
                   }
                   else if (i % 5 == 0)
                   {
                       result[i] = "Buzz";
                   }
                   else
                   {
                       result[i] = i.ToString();
                   }
               }

               // Loop again to show the results of the array based on the index position
               for (int i = 1; i <= number; i++)
               {
                   Console.WriteLine("Position " + i + " = " + result[i]);
               }
           }
           else
           {
               Console.WriteLine("Please enter a positive integer");
           }
       }
   }
}
