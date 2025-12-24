using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining
{
    internal class TallestAndYoungest
    {
        public static void Main(string[] args)
        {
            //Take user input for age the 3 friends
            //and store it in two arrays each to
            //store the values for age and height of the 3 friends
            //Taking user input for age of the 3 friends for comparison of age between all 3 friends
            int firstAge = Convert.ToInt32(Console.ReadLine());
            int secondAge = Convert.ToInt32(Console.ReadLine());
            int thirdAge = Convert.ToInt32(Console.ReadLine());
            //Taking user input for the height of 3 friends for comparison of age between all 3 friends
            int firstHeight = Convert.ToInt32(Console.ReadLine());
            int secondHeight = Convert.ToInt32(Console.ReadLine());
            int thirdHeight = Convert.ToInt32(Console.ReadLine());
            //After taking user input intializing the array to store the age of all 3 friends
            int[] age = new int[3];
            //After intializing the array storing the all 3 data to the array using each of data
            age[0] = firstAge;
            age[1] = secondAge;
            age[2] = thirdAge;
            //After taking user input intializing the array to store the height of all 3 friends
            int[] height = new int[3];
            //After intializing the array storing the all 3 data to the array using each of data
            height[0] = firstHeight;
            height[1] = secondHeight;
            height[2] = thirdHeight;
            //Checking through if else condition whom out of 3 is the youngest
            if (age[0] < age[1] && age[0] < age[2])
            {
                //Printing the age of the person who is the youngest from all 3 friends
                Console.WriteLine("The youngest out of 3 friends are with the age of" + " " + age[0]);
            }
            else if (age[1] < age[0] && age[1] < age[2])
            {
                //Printing the age of the person who is the youngest from all 3 friends
                Console.WriteLine("The youngest out of 3 friends are with the age of" + " " + age[1]);
            }
            else
            {
                //Printing the age of the person who is the youngest from all 3 friends
                Console.WriteLine("The youngest out of 3 friends are with the age of" + " " + age[2]);

            }
            //Checking through if else condition whom out of 3 is the tallest
            if (height[0] > height[1] && height[0] > height[2])
            {
                //Printing the height of the person who is the tallest from all 3 friends
                Console.WriteLine("The tallest out of 3 friends are with the height of" + " " + height[0]);
            }
            else if (height[1] > height[0] && height[1] > height[2])
            {
                //Printing the height of the person who is the tallest from all 3 friends
                Console.WriteLine("The tallest out of 3 friends are with the height of" + " " + height[1]);
            }
            else
            {
                //Printing the height of the person who is the tallest from all 3 friends
                Console.WriteLine("The tallest out of 3 friends are with the height of" + " " + height[2]);
            }
        }
    }
}