using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays
{
   internal class MeanHeight
   {
       public static void Main(string[] args)
       {
           //Create a double array named heights of size 11
           double[] heights = new double[11];
           //Initailizing the value of sum as intial value 0
           double sum = 0;
           //Getting input values from the user
           for(int i=0; i < heights.Length; i++)
           {
               heights[i] = Convert.ToDouble(Console.ReadLine());
           }
           //Calculating the sum of the array using the for loop 
           for(int i=0; i < heights.Length; i++)
           {
               sum += heights[i];
           }
           //Finding the mean height by dividing the sum by 11 to find the mean height
           double meanHeight = sum / 11;
           //Printing the mean height of the football team
           Console.WriteLine(meanHeight);

       }
   }
}
