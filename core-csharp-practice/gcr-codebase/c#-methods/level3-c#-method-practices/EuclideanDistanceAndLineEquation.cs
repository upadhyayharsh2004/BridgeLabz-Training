using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class EuclideanDistanceAndLineEquation
    {
        public static void Main(string[] args)
        {
            // Taking inputs for the first point (x1, y1)
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            // Taking inputs for the second point (x2, y2)
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Calling method to find the Euclidean distance between two points
            double distance = FindEuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine("Euclidean Distance = " + distance);

            // Calling method to find the equation of the line (slope and y-intercept)
            double[] lineEquation = FindLineEquation(x1, y1, x2, y2);

            // Displaying the slope and y-intercept
            Console.WriteLine("Slope (m) = " + lineEquation[0]);
            Console.WriteLine("Y-Intercept (b) = " + lineEquation[1]);

            // Displaying the equation of the line
            Console.WriteLine("Equation of the Line: y = " + lineEquation[0] + " * x + " + lineEquation[1]);
        }

        // Method to find the Euclidean distance between two points and return the distance
        public static double FindEuclideanDistance(double x1, double y1, double x2, double y2)
        {
            // Calculating distance using the formula sqrt((x2 - x1)^2 + (y2 - y1)^2)
            double distance = Math.Sqrt(
                Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
            );

            // Returning the calculated distance
            return distance;
        }

        // Method to find the equation of a line given two points
        // Returns an array where index 0 is slope (m) and index 1 is y-intercept (b)
        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            // Creating an array to store slope and y-intercept
            double[] result = new double[2];

            // Calculating slope using the formula m = (y2 - y1) / (x2 - x1)
            double m = (y2 - y1) / (x2 - x1);

            // Calculating y-intercept using the formula b = y1 - m * x1
            double b = y1 - (m * x1);

            // Storing slope and y-intercept in the array
            result[0] = m;
            result[1] = b;

            // Returning the result array
            return result;
        }
    }
}
