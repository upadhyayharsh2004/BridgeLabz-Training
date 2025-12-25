using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class SumOfNaturalNumbers
   {
       public static void Main(string[] args)
       {
           //Getting integer input from the user for calculating the sum of n natural numbers 
           int number = Convert.ToInt32(Console.ReadLine());
           //Creating an instance or object of the class to access non static method in a static method
           SumOfNaturalNumbers sN = new SumOfNaturalNumbers();
           //Calling a method to calculate the sum of n natural numbers and storing it in a variable to print further
           int sumOfNatural = sN.CalculateSumOfNaturalNumbers(number);
           Console.Write("The Sum of" + " " + number + " " + "natural numbers is" + " " + sumOfNatural);
       }
       //Initailizing the variable sum to calculate the sum of n natural numbers
       int sumCalculate = 0;
       public int CalculateSumOfNaturalNumbers(int number)
       {
           //Using a for loop to calculate the sum of n natural numbers
           for(int i = 0; i <= number; i++)
           {
               //Adding the value of i to the sum variable for calculating the sum of n natural numbers
               sumCalculate += i;
           }
           //Returning the sum of the n natural numbers to method where it has been called
           return sumCalculate;
       }
   }
}
