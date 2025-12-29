using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based
{
    internal class StudentTestScores
    {
        public static void Main(string[] args)
        {
            //Taking User Input as a integer in the n variable for Student Scores 
            int n;

            // Re-ask until valid number of students is entered until the number get valid 
            while (true)
            {
                // Prompt the user for input
                Console.WriteLine("Enter number of students:");

                // Try to parse the input as an integer
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    // Valid input, exit the loop
                    break;
                }
                else
                {
                    // Invalid input, display an error message
                    Console.WriteLine("Invalid input! Please enter a positive number.");
                }
            }
            //Intializing and Creating a New Array For Taking Input Of The Student Scores 
            int[] studentScores = new int[n];


            // Re-ask until valid score is entered for each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                // Prompt the user for input
                while (true)
                {
                    // Prompt the user for input
                    Console.WriteLine("Enter score for student " + (i + 1));

                    // Try to parse the input as an integer
                    if (int.TryParse(Console.ReadLine(), out int score) && score >= 0)
                    {
                        // Valid score, assign it to the array and exit the loop
                        studentScores[i] = score;

                        // Exit the inner loop
                        break;
                    }
                    else
                    {
                        // Invalid score, display an error message
                        Console.WriteLine("Invalid score! Enter a non-negative number.");
                    }
                }
            }
            //Taking User Input As A String For Validating The Numeric Input
            int number;

            // Re-ask until valid numeric input is entered
            while (true)
            {
                // Prompt the user for input
                Console.WriteLine("Enter a number:");

                // Try to parse the input as an integer
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    // Valid numeric input
                    Console.WriteLine("You entered: " + number);

                    // Exit the loop
                    break;
                }
                else
                {
                    // Non-numeric input, display an error message
                    Console.WriteLine("Invalid input! Please enter a numeric value.");
                }
            }

            //Creating an Object for accessing The Non static Member Into The Static Member;
            StudentTestScores studentTestScores = new StudentTestScores();

            //Using The Method For Finding The Average Of Scores From Each Student Scores
            float averageScoresChecked = studentTestScores.AverageOfScores(studentScores);

            //Using The Method For Finding The Highest Of Scores From Each Student Scores
            int HighestScoresChecked = studentTestScores.HighestScores(studentScores);

            //Using The Method For Finding The Lowest Of Scores From Each Student Scores
            int LowestScoresChecked = studentTestScores.LowestScores(studentScores);

            //Using The Method For Displaying All The Scores That Each Students Gets Above The Average Scores
            studentTestScores.DisplayScores(studentScores, averageScoresChecked);

            //Using The Method For Checking The Number Of Students In The Class Is Valid Or Not
            bool checkedNumber = studentTestScores.checkNumber(n);

            //Printing The Average Scores, Highest Scores And Lowest Scores That Each Student Gets In The Class
            Console.WriteLine("The Average Scores Of The Students In The Class Is" + " " + averageScoresChecked);

            //Printing The Highest Scores That Each Student Gets In The Class
            Console.WriteLine("The Highest Scores Of The Students In The Class Is" + " " + HighestScoresChecked);

            //Printing The Lowest Scores That Each Student Gets In The Class
            Console.WriteLine("The Lowest Scores Of The Students In The Class Is" + " " + LowestScoresChecked);

        }
        //Creating A Method For Checking The Number Of Students In The Class Is Valid Or Not
        public bool checkNumber(int n)
        {
            //Using If Condition To Check The Number Of Students In The Class Is Valid Or Not
            if (n <= 0)
            {
                // Invalid number of students
                Console.WriteLine("The Number Of Students In The Class Is Invalid");

                //Returning False If The Number Of Students In The Class Is Invalid
                return false;
            }
            else
            {
                // Valid number of students
                Console.WriteLine("The Number Of Students In The Class Is Valid");

                //Returning True If The Number Of Students In The Class Is Valid
                return true;
            }
        }
        //Creating A Method For Finding The Average Scores 
        public float AverageOfScores(int[] scoresOfStudents)
        {
            //Intializing The variable With The Intial Value 0 For Finding Sum Of Scores 
            int sumOfScores = 0;

            //Using For Loop To The Length Of The Array For Finding the Sum Of Scores
            for (int i = 0; i < scoresOfStudents.Length; i++)
            {
                //Adding The Value Of Each Student Scores To The Sum Of Scores Variable 
                sumOfScores += scoresOfStudents[i];
            }
            //Finding The Average Of Scores And Initailzing it to the average Scores Varaible
            float averageScores = sumOfScores / (scoresOfStudents.Length);

            //Returning The Value Of Average Of Scores To The Method Where It has Been Called
            return averageScores;
        }
        //Creating A Method For Finding The Highest Scores From The Class
        public int HighestScores(int[] scoreStudentsHighest)
        {
            //Intializing The variable With The Intial Value 0 For Finding Highest Of Scores
            int maxScores = 0;

            //Using For Loop To The Length Of The Array For Finding the Highest Of Scores
            for (int i = 0; i < scoreStudentsHighest.Length; i++)
            {
                //Comparing The Value Of Each Student Scores To The Maximum Scores Variable
                if (maxScores < scoreStudentsHighest[i])
                {
                    //If The Maximum Value Found Then Assign That Maximum Value To The Maximum Scores Variable 
                    maxScores = scoreStudentsHighest[i];
                }
            }
            //Returning The Value Of Maximum Scores To The Method Where It has Been Called
            return maxScores;
        }
        //Creating A Method For Finding The Lowest Scores From The Class
        public int LowestScores(int[] scoreStudentsLowest)
        {
            //Intializing The variable With The Intial Value 0 For Finding Lowest Of Scores
            int minScores = scoreStudentsLowest[0];

            //Using For Loop To The Length Of The Array For Finding the Lowest Of Scores
            for (int i = 0; i < scoreStudentsLowest.Length; i++)
            {
                //Comparing The Value Of Each Student Scores To The Minimum Scores Variable
                if (minScores > scoreStudentsLowest[i])
                {
                    //If The Minimum Value Found Then Assign That Minimum Value To The Minimum Scores Variable
                    minScores = scoreStudentsLowest[i];
                }
            }
            //Returning The Value Of Minimum Scores To The Method Where It has Been Called
            return minScores;
        }
        //Creating A Method For Displaying The Scores That Each Student Gets
        public void DisplayScores(int[] scoresDisplay, float averageScoreStudents)
        {
            //Using For Loop To The Length Of The Array For Displaying The Scores That Each Student Gets
            for (int i = 0; i < scoresDisplay.Length; i++)
            {
                if (scoresDisplay[i] > averageScoreStudents)
                {
                    //Printing The Scores That Each Student Gets In The Class
                    Console.WriteLine("The Scores Of Each Student In The Class is" + " " + scoresDisplay[i]);
                }
            }
        }
    }
}

