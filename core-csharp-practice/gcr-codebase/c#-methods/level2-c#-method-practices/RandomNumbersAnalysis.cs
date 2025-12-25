using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class RandomNumbersAnalysis
    {
        public static void Main(string[] args)
        {
            // Defining the size of the array as 5
            int size = 5;
            // Creating an object of the class to access non-static methods
            RandomNumbersAnalysis rO=new RandomNumbersAnalysis();
            // Calling method to generate array of 4 digit random numbers
            int[] randomNumbers=rO.Generate4DigitRandomArray(size);
            // Displaying the generated random numbers
            Console.WriteLine("Generated 4 Digit Random Numbers:");
            for (int i=0;i<randomNumbers.Length;i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }
            Random random=new Random();
            // Calling method to find average, minimum and maximum values
            double[]result=rO.FindAverageMinMax(randomNumbers);
            // Displaying the average, minimum and maximum values
            Console.WriteLine("Average Value="+result[0]);
            Console.WriteLine("Minimum Value="+result[1]);
            Console.WriteLine("Maximum Value="+result[2]);
        }
        // Write a method that generates array of 4 digit random numbers given the size as a parameter
        public int[] Generate4DigitRandomArray(int size)
        {
            // Creating an integer array of given size
            int[]numbers=new int[size];
            // Loop to generate 4 digit random numbers
            for (int i=0;i<size;i++)
            {
                // Generating a random 4 digit number using Math.Random()
                numbers[i]=(int)(random.Next(1000,10000)*9000)+1000;
            }
            // Returning the generated array
            return numbers;
        }
        // Write a method to find average, minimum and maximum value of an array
        public double[] FindAverageMinMax(int[]numbers)
        {
            // Creating an array to store average, min and max values
            double[]result=new double[3];
            // Initializing sum, min and max values
            double sum=0;
            int min=numbers[0];
            int max=numbers[0];
            // Looping through the array to calculate sum, min and max
            for (int i=0;i<numbers.Length;i++)
            {
                sum=sum+numbers[i];
                min=Math.Min(min,numbers[i]);
                max=Math.Max(max,numbers[i]);
            }
            // Calculating average
            double average=sum/numbers.Length;
            // Storing average, min and max in result array
            result[0]=average;
            result[1]=min;
            result[2]=max;
            // Returning the result array
            return result;
        }
    }
}
