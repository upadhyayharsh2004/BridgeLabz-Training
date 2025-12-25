using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class StudentScoreCard
    {
        public static void Main(string[] args)
        {
            // Taking input for the number of students
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Calling method to generate random PCM scores for all students
            double[,] pcmScores = GeneratePCMScores(numberOfStudents);

            // Calling method to calculate total, average, and percentage
            double[,] resultData = CalculateTotalAveragePercentage(pcmScores);

            // Calling method to display the scorecard of all students
            DisplayScoreCard(pcmScores, resultData);
        }

        // Method to generate random 2-digit scores for Physics, Chemistry, and Maths
        // Returns a 2D array where
        // Column 0 -> Physics, Column 1 -> Chemistry, Column 2 -> Maths
        public static double[,] GeneratePCMScores(int students)
        {
            double[,] scores = new double[students, 3];
            Random random = new Random();

            for (int i = 0; i < students; i++)
            {
                // Generating random 2-digit marks for each subject
                scores[i, 0] = random.Next(10, 100);
                scores[i, 1] = random.Next(10, 100);
                scores[i, 2] = random.Next(10, 100);
            }

            return scores;
        }

        // Method to calculate total, average, and percentage for each student
        // Returns a 2D array where
        // Column 0 -> Total, Column 1 -> Average, Column 2 -> Percentage
        public static double[,] CalculateTotalAveragePercentage(double[,] pcmScores)
        {
            int students = pcmScores.GetLength(0);
            double[,] result = new double[students, 3];

            for (int i = 0; i < students; i++)
            {
                // Calculating total marks
                double total = pcmScores[i, 0] + pcmScores[i, 1] + pcmScores[i, 2];

                // Calculating average marks
                double average = total / 3;

                // Calculating percentage
                double percentage = (total / 300) * 100;

                // Rounding off values to 2 digits
                result[i, 0] = Math.Round(total, 2);
                result[i, 1] = Math.Round(average, 2);
                result[i, 2] = Math.Round(percentage, 2);
            }

            return result;
        }

        // Method to display the scorecard of all students in tabular format
        public static void DisplayScoreCard(double[,] pcmScores, double[,] resultData)
        {
            Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

            for (int i = 0; i < pcmScores.GetLength(0); i++)
            {
                Console.WriteLine(
                    (i + 1) + "\t" +
                    pcmScores[i, 0] + "\t" +
                    pcmScores[i, 1] + "\t\t" +
                    pcmScores[i, 2] + "\t" +
                    resultData[i, 0] + "\t" +
                    resultData[i, 1] + "\t" +
                    resultData[i, 2]
                );
            }
        }
    }
}
