using System;

namespace BridgeLabzTraining
{
    internal class BmiCalculator
    {
        public static void Main(string[] args)
        {
            // Take input for a number of persons
            int numberOfPersons = Convert.ToInt32(Console.ReadLine());
            // Create arrays to store the weight of the persons
            double[] weight = new double[numberOfPersons];
            // Create arrays to store the height of the persons
            double[] height = new double[numberOfPersons];
            // Create arrays to store the BMI of the persons
            double[] bmi = new double[numberOfPersons];
            // Create arrays to store the weight status of the persons
            string[] status = new string[numberOfPersons];
            // Take input for the weight and height of the persons
            for (int i = 0; i < numberOfPersons; i++)
            {
                // Taking weight input from the user
                weight[i] = Convert.ToDouble(Console.ReadLine());
                // Taking height input from the user (in meters)
                height[i] = Convert.ToDouble(Console.ReadLine());
            }
            // Calculate the BMI of all the persons and find the weight status
            for (int i = 0; i < numberOfPersons; i++)
            {
                // Calculate BMI using the formula BMI = weight / (height * height)
                bmi[i] = weight[i] / (height[i] * height[i]);
                // Use the table to determine the weight status of the person
                if (bmi[i] <= 18.4)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
                {
                    status[i] = "Normal";
                }
                else if (bmi[i] >= 25.0 && bmi[i] <= 39.9)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }
            // Display the height, weight, BMI, and weight status of each person
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine("Person" + (i + 1));
                Console.WriteLine("Height=" + height[i]);
                Console.WriteLine("Weight=" + weight[i]);
                Console.WriteLine("BMI =" + bmi[i]);
                Console.WriteLine("Status=" + status[i]);
                Console.WriteLine();
            }
        }
    }
}
