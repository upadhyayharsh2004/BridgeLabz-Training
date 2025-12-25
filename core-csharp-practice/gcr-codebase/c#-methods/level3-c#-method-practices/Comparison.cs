using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class Comparison
    {
        public static void Main(string[] args)
        {
            int[] heights = new int[11];
            Comparison c = new Comparison();
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = c.Get4DigitRandomNumber();
            }
            int resultOfSum = c.SumElements(heights);
            int resultOfMean = c.MeanElements(heights);
            int shortestHeight = c.FindShortestHeight(heights);
            int tallestHeight = c.FindTallestHeight(heights);
            Console.WriteLine("Heights of Football Players:");
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " Height = " + heights[i] + " cm");
            }
            // Displaying the results
            Console.WriteLine();
            Console.WriteLine("Sum of Heights = " + resultOfSum);
            Console.WriteLine("Mean Height = " + resultOfMean);
            Console.WriteLine("Shortest Height = " + shortestHeight);
            Console.WriteLine("Tallest Height = " + tallestHeight);
        }
        // Generate a 4-digit random number
        public int Get4DigitRandomNumber()
        {
            Random random = new Random();
            return random.Next(150, 250); // Generates a random number between 150 and 250
        }
        public int SumElements(int[] studentHeights)
        {
            int sum = 0;
            for (int i = 0; i < studentHeights.Length; i++)
            {
                sum += studentHeights[i];
            }
            return sum;
        }
        public int MeanElements(int[] studentHeightsMeans)
        {
            double sum = 0;
            for (int i = 0; i < studentHeightsMeans.Length; i++)
            {
                sum += studentHeightsMeans[i];
            }
            double mean = sum / 11;
            return (int)mean;
        }
        public int FindShortestHeight(int[]heights)
        {
            int shortest = heights[0];
            for (int i=1;i<heights.Length;i++)
            {
                if (heights[i]<shortest)
                {
                    shortest=heights[i];
                }
            }
            return shortest;
        }
        public int FindTallestHeight(int[]heights)
        {
            int tallest=heights[0];
            for (int i=1;i<heights.Length;i++)
            {
                if (heights[i]>tallest)
                {
                    tallest=heights[i];
                }
            }
            return tallest;
        }
    }
}
