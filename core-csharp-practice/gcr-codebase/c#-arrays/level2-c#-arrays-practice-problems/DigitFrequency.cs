using System;
namespace BridgeLabzTraining
{
    internal class DigitFrequency
    {
        public static void Main(string[] args)
        {
            // Take the input for a number
            int number = Convert.ToInt32(Console.ReadLine());
            // Store the original number for later use
            int tempNumber = number;
            // Find the count of digits in the number
            int digitCount = 0;
            while (tempNumber > 0)
            {
                digitCount++;
                tempNumber = tempNumber / 10;
            }
            // Create an array to store the digits of the number
            int[] digits = new int[digitCount];
            // Reset tempNumber to original number
            tempNumber = number;
            // Find the digits in the number and save them in an array
            int index = 0;
            while (tempNumber > 0)
            {
                digits[index] = tempNumber % 10;
                tempNumber = tempNumber / 10;
                index++;
            }
            // Define a frequency array of size 10 to store frequency of digits 0 to 9
            int[] frequency = new int[10];
            // Loop through the digits array and increase the frequency of each digit
            for (int i = 0; i < digits.Length; i++)
            {
                frequency[digits[i]]++;
            }
            // Display the frequency of each digit in the number
            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine("Digit" + i + "=" + frequency[i]);
                }
            }
        }
    }
}
