using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class HandShakes
   {
       public static void Main(string[] args)
       {
           //Getting integer input for number of students
           int numberOfStudents = Convert.ToInt32(Console.ReadLine());
           //Creating an instance or object of the class to access non static method in a static method
           HandShakes hs = new HandShakes();
           //Calling a method to calculate the number of HandShakes using the formula and storing it in a variable to print further
           int resultOfHandShakes = hs.HandShakesCount(numberOfStudents);
           //Printing the number of possible HandShakes to the output screen
           Console.WriteLine("The number of possible handshakes are" + " " + resultOfHandShakes);
       }
       public int HandShakesCount(int numberOfStudents)
       {
           //Calculating the count of HandShakes using the formula and storing it in a varaible to return further
           int countOfHandShakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
           //Returning the count of Hand Shakes after calculating no of possible handshakes
           return countOfHandShakes;
       }
   }
}
