using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class SimpleInterestCalculator
   {
       public static void Main(string[] args)
       {
           //Taking User input for the principal for calculation of Simple Interest
           double principal = Convert.ToDouble(Console.ReadLine());
           //Taking User input for the rate for calculation of Simple Interest
           double rate = Convert.ToDouble(Console.ReadLine());
           //Taking User input for the time for calculation of Simple Interest
           float time = Convert.ToSingle(Console.ReadLine());
           //Create a object of the class SimpleInterest
           SimpleInterestCalculator si = new SimpleInterestCalculator();
           //Calling the method using the object we have created and storing it in a simpleICalculator variable 
           double simpleICalculator = si.SimpleInterest(principal, rate, time);
           //Printing the output to the output screeen with the sentence as provided
           Console.WriteLine("The Simple Interest is" + " " + simpleICalculator + " " + "for principal" + " " + principal + "," + " " + "Rate of Interest" + " " + rate + " " + "and Time" + " " + time);
       }
       public double SimpleInterest(double principal, double rate, float time)
       {
           //Calculating the result of simple interest using the formula
           double result = (principal * rate * time) / 100;
           //Returning the result to the method where it has been called 
           return result;
       }
   }
}
