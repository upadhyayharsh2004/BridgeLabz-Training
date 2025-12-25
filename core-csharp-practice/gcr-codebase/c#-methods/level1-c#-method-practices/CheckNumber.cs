using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class CheckNumber
   {
       public static void Main(string[] args)
       {
           //Getting integer input from the user for checking the number is positive , negative or zero
           int numberToCheck= Convert.ToInt32(Console.ReadLine());
           //Creating an instance or object of the class to access non static method in a static method
           CheckNumber nC = new CheckNumber();
           //Calling a method to check that the number is positive negative or zero and storing it in a variable to print further
           string resultOfNumberChecked = nC.NumberChecking(numberToCheck);
           //Printing that the number is positive negative or zero to the output screen
           Console.WriteLine("The Number Which Has Been Checked It's" + " " +resultOfNumberChecked);
       }
       public string NumberChecking(int numberToChecking)
       {
           //Using if else condition to check whether the number is positive negative or zero according to condition and also returning to the method called in a main method
           if (numberToChecking < 0)
           {
               return "A Negative Number";
           }
           else if (numberToChecking > 0)
           {
               return "A Positive Number";
           }
           else
           {
               return "A Zero";
           }
       }
   }
}
