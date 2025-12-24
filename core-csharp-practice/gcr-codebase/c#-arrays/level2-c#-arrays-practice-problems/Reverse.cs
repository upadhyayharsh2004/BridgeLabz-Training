using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining
{
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            //Taking user input for a number into number variable for finding reverse of the number4
            int number = Convert.ToInt32(Console.ReadLine());
            //Initializing the variable count with the intial value 0 for counting the number of digits 
            int count = 0;
            //Creating temp variable for finding the digits of a number using while loop 
            int temp = number;
            //Using While loop for finding the count of digits of a number using divison operator till the number doesnt become 0
            while (temp != 0)
            {
                //Increasing the count by 1 to count number of digits in a number
                count++;
                //Dividing the temp by 10 to get again the count of digits in an number
                temp = temp / 10;
            }
            //Creating and Intializing the array to store the digits of a number using the for loop
            int[] digits = new int[count];
            //Using for loop to extract the digits from a number to find reverse of that number
            for (int i = 0; i < digits.Length; i++)
            {
                //Finding the remainder of a number to store that in array
                int remainder = number % 10;
                //Storing the last digit of a number in the array for reversing that array
                digits[i] = remainder;
                //Dividing the number by 10 to get again the count of digits in an number and store that in the array
                number = number / 10;
            }
            //Creating an array for taking the number of digits array into the reverse order 
            int[] reverse = new int[digits.Length];
            //Using for loop to store number into reverse array from the digits array in the form of reverse loop
            for (int i = 0; i < digits.Length; i++)
            {
                //Storing the numbers from digits array into the reverse array 
                reverse[i] = digits[i];
            }
            //Using for loop to print the numbers of the reverse array
            for (int i = 0; i < reverse.Length; i++)
            {
                //Printing the content of reverse array to the output screen
                Console.WriteLine("The reverse array elements are" + " " + reverse[i]);
            }
        }
    }
}
