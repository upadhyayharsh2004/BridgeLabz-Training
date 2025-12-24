using System;

namespace BridgeLabzTraining.arrays
{
    internal class StoreMultipleValues
    {
        public static void Main(string[] args)
        {
            // Create a variable to store an array of 10 elements of type double
            double[] numbers = new double[10];
            // Create a variable to store the total of type double initializes to 0.0
            double total = 0.0;
            // Also, the index variable is initialized to 0 for the array
            int index = 0;
            // Use infinite while loop as in while (true)
            while (true)
            {
                // Take the user entry
                double value = Convert.ToDouble(Console.ReadLine());
                // Check if the user entered 0 or a negative number to break the loop
                if (value <= 0)
                {
                    break;
                }
                // Also, break from the loop if the index has a value of 10 as the array size is limited to 10
                if (index == 10)
                {
                    break;
                }
                // If the user entered a number other than 0 or a negative number inside the while loop
                // then assign the number to the array element and increment the index value
                numbers[index] = value;
                index++;
            }
            // Take another for loop to get the values of each element and add it to the total
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("Value at position " + i + " = " + numbers[i]);
                total = total + numbers[i];
            }
            // Finally display the total value
            Console.WriteLine("Total = " + total);
        }
    }
}
