using System;

namespace BridgeLabzTraining
{
    internal class StudentGradeCalculator
    {
        public static void Main(string[] args)
        {
            // Take input for the number of students
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            // Create a 2D array to store marks of students in physics, chemistry, and maths
            // Index 0 -> Physics, Index 1 -> Chemistry, Index 2 -> Maths
            double[,] marks = new double[numberOfStudents, 3];
            // Create arrays to store percentages of the students
            double[] percentage = new double[numberOfStudents];
            // Create arrays to store grades of the students
            string[] grade = new string[numberOfStudents];
            // Take input for marks of students in physics, chemistry, and maths
            for (int i = 0; i < numberOfStudents; i++)
            {
                // Taking physics marks input
                double physics = Convert.ToDouble(Console.ReadLine());
                // Taking chemistry marks input
                double chemistry = Convert.ToDouble(Console.ReadLine());
                // Taking maths marks input
                double maths = Convert.ToDouble(Console.ReadLine());
                // If the marks are negative, ask the user to enter positive values and decrement the index
                if (physics < 0 || chemistry < 0 || maths < 0)
                {
                    i--;
                    continue;
                }
                // Storing valid marks in the 2D array
                marks[i, 0] = physics;
                marks[i, 1] = chemistry;
                marks[i, 2] = maths;
            }
            // Calculate the percentage and grade of the students based on the percentage
            for (int i = 0; i < numberOfStudents; i++)
            {
                // Calculating percentage using 2D array values
                percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;
                // Assigning grade based on percentage
                if (percentage[i] >= 80)
                {
                    grade[i] = "A";
                }
                else if (percentage[i] >= 70 && percentage[i] <= 79)
                {
                    grade[i] = "B";
                }
                else if (percentage[i] >= 60 && percentage[i] <= 69)
                {
                    grade[i] = "C";
                }
                else if (percentage[i] >= 50 && percentage[i] <= 59)
                {
                    grade[i] = "D";
                }
                else if (percentage[i] >= 40 && percentage[i] <= 49)
                {
                    grade[i] = "E";
                }
                else
                {
                    grade[i] = "R";
                }
            }
            // Display the marks, percentages, and grades of each student
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Student" + (i + 1));
                Console.WriteLine("Physics Marks=" + marks[i, 0]);
                Console.WriteLine("Chemistry Marks=" + marks[i, 1]);
                Console.WriteLine("Maths Marks=" + marks[i, 2]);
                Console.WriteLine("Percentage=" + percentage[i]);
                Console.WriteLine("Grade=" + grade[i]);
                Console.WriteLine();
            }
        }
    }
}
