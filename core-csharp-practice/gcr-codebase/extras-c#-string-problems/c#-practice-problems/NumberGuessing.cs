using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class NumberGuessing
    {
        public static void Main()
        {
            // Inform the user about the game
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("I will try to guess it.");
            Console.WriteLine("Enter feedback as: high, low, or correct.");
            Console.WriteLine();
            // Initialize the lower and upper bounds
            int low=1;
            int high=100;
            // Start the guessing process
            StartGuessing(low,high);
        }
        // Function to control the guessing process
        // Parameters:
        // int low-lower bound of the guessing range
        // int high-upper bound of the guessing range
        static void StartGuessing(int low,int high)
        {
            bool isCorrect=false;
            // Continue guessing until the correct number is found
            while (!isCorrect&&low<=high)
            {
                // Generate a guess
                int guess=GenerateGuess(low,high);
                // Display the guess
                Console.WriteLine("My guess is:"+ guess);
                // Get feedback from the user
                string feedback=GetUserFeedback();
                // Determine the next range based on feedback
                if (feedback=="correct")
                {
                    Console.WriteLine("Great! I guessed your number correctly.");
                    isCorrect=true;
                }
                else if(feedback=="high")
                {
                    // Guess was too high, reduce upper bound
                    high=guess-1;
                }
                else if(feedback=="low")
                {
                    // Guess was too low, increase lower bound
                    low=guess+1;
                }
                else
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid input. Please enter high, low, or correct.");
                }

                Console.WriteLine();
            }
        }
        // Function to generate a guess within the given range
        // Parameters:
        // int low-lower bound
        // int high-upper bound
        // Return type: int-generated guess
        static int GenerateGuess(int low,int high)
        {
            // Generate a guess by taking the middle value
            int guess=(low+high)/2;
            return guess;
        }

        // Function to get feedback from the user
        // Return type: string - user feedback (high, low, or correct)
        static string GetUserFeedback()
        {
            Console.Write("Is the guess high, low, or correct? ");
            string feedback=Console.ReadLine().ToLower();
            return feedback;
        }
    }
}

