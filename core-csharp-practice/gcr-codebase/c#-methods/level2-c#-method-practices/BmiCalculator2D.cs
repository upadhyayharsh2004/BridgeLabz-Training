using System;
namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class BmiCalculator2D
    {
        public static void Main(string[] args)
        {
            // Creating a 2D array of 10 rows and 3 columns
            // Column 0 -> Weight (kg)
            // Column 1 -> Height (cm)
            // Column 2 -> BMI
            double[,] personData = new double[10, 3];
            // Creating an array to store BMI status of each person
            string[] bmiStatus = new string[10];
            // Taking user input for weight and height of 10 persons
            for (int i = 0; i < 10; i++)
            {
                // Taking user input for weight in kg
                double weight = Convert.ToDouble(Console.ReadLine());
                // Taking user input for height in cm
                double height = Convert.ToDouble(Console.ReadLine());
                // Storing weight and height in the 2D array
                personData[i, 0] = weight;
                personData[i, 1] = height;
            }
            // Calling method to calculate BMI of every person and populate the array
            CalculateBMI(personData);
            // Calling method to determine BMI status of every person
            bmiStatus = DetermineBMIStatus(personData);
            // Displaying height,weight,BMI and status of each individual
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Person" + (i + 1));
                Console.WriteLine("Weight(kg)=" + personData[i, 0]);
                Console.WriteLine("Height(cm)=" + personData[i, 1]);
                Console.WriteLine("BMI=" + personData[i, 2]);
                Console.WriteLine("Status=" + bmiStatus[i]);
                Console.WriteLine();
            }
        }
        // Method to calculate the BMI of every person and populate the 2D array
        public static void CalculateBMI(double[,] personData)
        {
            for (int i = 0; i < 10; i++)
            {
                // Converting height from cm to meters
                double heightInMeters = personData[i, 1] / 100;
                // Calculating BMI using formula weight / (height * height)
                double bmi = personData[i, 0] / (heightInMeters * heightInMeters);
                // Storing BMI in the third column of the array
                personData[i, 2] = bmi;
            }
        }
        // Method to determine the BMI status of all persons and return the status array
        public static string[] DetermineBMIStatus(double[,] personData)
        {
            // Creating an array to store BMI status
            string[] status = new string[10];
            for (int i = 0; i < 10; i++)
            {
                double bmi = personData[i, 2];
                // Determining BMI status using the given table
                if (bmi <= 18.4)
                {
                    status[i] = "Underweight";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    status[i] = "Normal";
                }
                else if (bmi >= 25.0 && bmi <= 39.9)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }
            // Returning the BMI status array
            return status;
        }
    }
}
