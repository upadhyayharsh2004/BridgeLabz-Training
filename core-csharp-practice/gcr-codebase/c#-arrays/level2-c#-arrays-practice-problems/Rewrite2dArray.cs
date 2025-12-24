using System;
namespace BridgeLabzTraining
{
    internal class Rewrite2dArray
    {
        public static void Main(string[] args)
        {
            // Take input for a number of persons
            int number = Convert.ToInt32(Console.ReadLine());
            //Create a multi-dimensional array to store weight, height and BMI
            //Index 0 -> Weight, Index 1 -> Height, Index 2 -> BMI
            double[][] personData = new double[number][];
            //Create an array to store the weight status of the persons
            string[] weightStatus = new string[number];
            //Initialize each row of the jagged array with size 3
            for (int i = 0; i < number; i++)
            {
                personData[i] = new double[3];
            }
            //Take input for weight and height of the persons
            for (int i = 0; i < number; i++)
            {
                //Taking weight input
                double weight = Convert.ToDouble(Console.ReadLine());
                //Taking height input
                double height = Convert.ToDouble(Console.ReadLine());
                //For negative values, ask the user to enter positive values
                if (weight <= 0 || height <= 0)
                {
                    i--;
                    continue;
                }
                //Store weight and height in the 2D array
                personData[i][0] = weight;
                personData[i][1] = height;
            }
            //Calculate BMI of all the persons and determine the weight status
            for (int i = 0; i < number; i++)
            {
                //Calculate BMI and store it in the 2D array
                personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);
                //Use the BMI table to determine the weight status of the person
                if (personData[i][2] <= 18.4)
                {
                    weightStatus[i] = "Underweight";
                }
                else if (personData[i][2] >= 18.5 && personData[i][2] <= 24.9)
                {
                    weightStatus[i] = "Normal";
                }
                else if (personData[i][2] >= 25.0 && personData[i][2] <= 39.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obese";
                }
            }
            //Display the height, weight, BMI and status of each person
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Person" + (i + 1));
                Console.WriteLine("Weight=" + personData[i][0]);
                Console.WriteLine("Height=" + personData[i][1]);
                Console.WriteLine("BMI=" + personData[i][2]);
                Console.WriteLine("Status=" + weightStatus[i]);
                Console.WriteLine();
            }
        }
    }
}
