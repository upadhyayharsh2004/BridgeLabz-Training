using System;

namespace BridgeLabzTraining
{
    internal class StudentMarks
    {
        public static void Main(string[] args)
        {
            // Take input for the number of students
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            // Create arrays to store marks of students in physics
            double[] physics = new double[numberOfStudents];
            // Create arrays to store marks of students in chemistry
            double[] chemistry = new double[numberOfStudents];
            // Create arrays to store marks of students in maths
            double[] maths = new double[numberOfStudents];
            // Create arrays to store percentages of the students
            double[] percentage = new double[numberOfStudents];
            // Create arrays to store grades of the students
            string[] grade = new string[numberOfStudents];
            // Take input for marks of students in physics, chemistry, and maths
            for (int i = 0; i < numberOfStudents; i++)
            {
                // Taking physics marks input
                double phy = Convert.ToDouble(Console.ReadLine());
                // Taking chemistry marks input
                double chem = Convert.ToDouble(Console.ReadLine());
                // Taking maths marks input
                double math = Convert.ToDouble(Console.ReadLine());
                // If the marks are negative, ask the user to enter positive values and decrement the index
                if (phy < 0 || chem < 0 || math < 0)
                {
                    i--;
                    continue;
                }
                // Storing valid marks in arrays
                physics[i] = phy;
                chemistry[i] = chem;
                maths[i] = math;
            }
            // Calculate the percentage and grade of the students based on the percentage
            for (int i = 0; i < numberOfStudents; i++)
            {
                // Calculating percentage of the student
                percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3;
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
                Console.WriteLine("Physics Marks=" + physics[i]);
                Console.WriteLine("Chemistry Marks=" + chemistry[i]);
                Console.WriteLine("Maths Marks=" + maths[i]);
                Console.WriteLine("Percentage=" + percentage[i]);
                Console.WriteLine("Grade=" + grade[i]);
                Console.WriteLine();
            }
        }
    }
}
