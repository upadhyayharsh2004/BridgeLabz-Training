using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining
{
    internal class LargestAndSecondLargest
    {
        public static void Main(string[] args)
        {
            //Create a number variable and take user input. 
            int number = Convert.ToInt32(Console.ReadLine());
            //Initializing the maxDigit variable initially set to 10
            int maxDigit = 10;
            //Defining an array to store the digits for finding largest and second largest and setting the size of the array to maxDigit variable initially set to 10
            int[] digits = new int[maxDigit];
            //Creating an integer variable index with the value 0 to reflect the array index.
            int index = 0;
            //Using a loop to iterate until the number is not equal to 0.
            while (number != 0)
            {
                //Removing the last digit from the number in each iteration
                int remainder = number % 10;
                //After getting the last digit then adding it to the array.
                digits[index] = remainder;
                //Incrementing the index by 1 in each iteration
                index++;
                //If the index count equals maxDigit then breaking out of the loop 
                if (index == maxDigit)
                {
                    //And the remaining digits are not adding to the array after using break
                    break;
                }
                //Dividing the number by 10 so that the remainder can be generated again 
                number = number / 10;
            }
            //Defining variable to store largest and initialize it to zero
            int largest = 0;
            //Defining variable to store second largest and initialize it to zero
            int secondLargest = 0;
            //Loop through the array to find the the largest number in the array
            for (int i = 0; i < digits.Length; i++)
            {
                //Using conditional statements to find the largest number in the array
                if (largest < digits[i])
                {
                    //Assigning the that number to the largest variable for finding the largest number in the array
                    largest = digits[i];
                }
            }

            //for (int i = 0; i < digits.Length; i++)
            //{
            //    //Using conditional statements to find the second largest number in the array
            //    if (largest < digits[i] )
            //    {
            //        //Assigning the that number to the secondLargest variable for finding the second largest number in the array
            //        secondLargest = digits[i];
            //    }
            //}
            //Loop through the array to find the the second largest number in the array
            for (int i = 0; i < digits.Length; i++)
            {
                //Using conditional statements to find the second largest number in the array
                if (digits[i] > largest)
                {
                    //Assigning that number to the secondLargest and largest variable for finding the second largest number in the array
                    secondLargest = largest;
                    //Assigning that digits[i] number to the largest variable for finding the second largest number in the array
                    largest = digits[i];
                }
                //Using conditional statements to find the second largest number in the array
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    //Assigning that number to the secondLargest and largest variable for finding the second largest number in the array
                    secondLargest = digits[i];
                }
            }
            //Printing the largest number in the array
            Console.WriteLine(largest);
            //Printing the second largest number in the array
            Console.WriteLine(secondLargest);
        }
    }
}
