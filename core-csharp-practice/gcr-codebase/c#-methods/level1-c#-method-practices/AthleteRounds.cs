using System;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class AthleteRounds
   {
       public static void Main(string[] args)
       {
           // Taking user input for the three sides of the triangular park in meters
           double side1 = Convert.ToDouble(Console.ReadLine());
           double side2 = Convert.ToDouble(Console.ReadLine());
           double side3 = Convert.ToDouble(Console.ReadLine());
           // Creating an object of the class to access the method
           AthleteRounds athlete = new AthleteRounds();
           // Calling the method to calculate the number of rounds to complete 5 km run
           double rounds = athlete.CalculateNumberOfRounds(side1, side2, side3);
           // Displaying the number of rounds required to complete 5 km
           Console.WriteLine("Number of rounds required to complete 5 km"+"="+rounds);
       }
       // Write a Method to compute the number of rounds user needs to do to complete 5km run
       public double CalculateNumberOfRounds(double side1, double side2, double side3)
       {
           // Calculating the perimeter of the triangular park
           double perimeter = side1 + side2 + side3;
           // Total distance to be covered is 5 km (5000 meters)
           double totalDistance = 5000;
           // Calculating the number of rounds required
           double rounds = totalDistance / perimeter;
           // Returning the calculated number of rounds
           return rounds;
       }
   }
}
