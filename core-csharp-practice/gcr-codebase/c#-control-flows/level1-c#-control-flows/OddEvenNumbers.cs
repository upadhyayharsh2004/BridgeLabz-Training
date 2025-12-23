using System;
class OddEvenNumbers{
    public static void Main(string[] args){
        // Read input from the user and convert it to integer
        int number = Convert.ToInt32(Console.ReadLine());
        // Check if the entered number is a natural number (greater than 0)
        if (number <= 0){
            return; // Stop program execution
        }
        // Loop from 1 to the entered number
        for (int i = 1; i <= number; i++){
            // Check if the current number is even
            if (i % 2 == 0){
                // Print even number
                Console.WriteLine(i + " is an Even number");
            }
            else{
                // Print odd number
                Console.WriteLine(i + " is an Odd number");
            }
        }
    }
}
