using System;

namespace BridgeLabzTraining
{
    internal class LargestAndSecondLargestDigit
    {
        public static void Main(string[] args)
        {
            // Create a number variable and take user input
            int number = Convert.ToInt32(Console.ReadLine());
            // Define maxDigit variable initially set to 10
            int maxDigit = 10;
            // Define an array to store the digits with size maxDigit
            int[] digits = new int[maxDigit];
            // Create an integer variable index with the value 0 to reflect the array index
            int index = 0;
            // Use a loop to iterate until the number is not equal to 0
            while (number != 0)
            {
                // Remove the last digit from the number
                int digit = number % 10;
                // If the index is equal to maxDigit, increase maxDigit and resize the array
                if (index == maxDigit)
                {
                    // Increase maxDigit by 10
                    maxDigit = maxDigit + 10;
                    // Create a temp array of size maxDigit
                    int[] temp = new int[maxDigit];
                    // Copy the existing digits into the temp array
                    for (int i = 0; i < digits.Length; i++)
                    {
                        temp[i] = digits[i];
                    }
                    // Assign digits array to the temp array
                    digits = temp;
                }
                // Add the digit to the array
                digits[index] = digit;
                // Increment the index by 1
                index++;
                // Remove the last digit from the number
                number = number / 10;
            }
            // Define variables to store largest and second largest digit and initialize to zero
            int largest = 0;
            int secondLargest = 0;
            // Loop through the array to find the largest and second largest digit
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }
            // Finally display the largest and second-largest number
            Console.WriteLine("Largest Digit=" + largest);
            Console.WriteLine("Second Largest Digit=" + secondLargest);
        }
    }
}
