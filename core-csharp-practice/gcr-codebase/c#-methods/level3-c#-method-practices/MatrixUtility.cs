using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class MatrixUtility
    {
        public static void Main(string[] args)
        {
            // Sample 2x2 matrix
            double[,] matrix2x2 =
            {
                { 4, 7 },
                { 2, 6 }
            };

            // Sample 3x3 matrix
            double[,] matrix3x3 =
            {
                { 1, 2, 3 },
                { 0, 1, 4 },
                { 5, 6, 0 }
            };

            // Displaying original matrices
            Console.WriteLine("Original 2x2 Matrix:");
            DisplayMatrix(matrix2x2);

            Console.WriteLine("Original 3x3 Matrix:");
            DisplayMatrix(matrix3x3);

            // Finding and displaying transpose
            Console.WriteLine("Transpose of 2x2 Matrix:");
            DisplayMatrix(FindTranspose(matrix2x2));

            Console.WriteLine("Transpose of 3x3 Matrix:");
            DisplayMatrix(FindTranspose(matrix3x3));

            // Finding and displaying determinants
            Console.WriteLine("Determinant of 2x2 Matrix = " + FindDeterminant2x2(matrix2x2));
            Console.WriteLine("Determinant of 3x3 Matrix = " + FindDeterminant3x3(matrix3x3));

            // Finding and displaying inverse matrices
            Console.WriteLine("Inverse of 2x2 Matrix:");
            DisplayMatrix(FindInverse2x2(matrix2x2));

            Console.WriteLine("Inverse of 3x3 Matrix:");
            DisplayMatrix(FindInverse3x3(matrix3x3));
        }

        // Method to find the transpose of a matrix
        public static double[,] FindTranspose(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] transpose = new double[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }

            return transpose;
        }

        // Method to find the determinant of a 2x2 matrix
        public static double FindDeterminant2x2(double[,] matrix)
        {
            // Determinant = ad - bc
            return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }

        // Method to find the determinant of a 3x3 matrix
        public static double FindDeterminant3x3(double[,] matrix)
        {
            double determinant =
                matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
              - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
              + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return determinant;
        }

        // Method to find the inverse of a 2x2 matrix
        public static double[,] FindInverse2x2(double[,] matrix)
        {
            double determinant = FindDeterminant2x2(matrix);
            double[,] inverse = new double[2, 2];

            // Inverse exists only if determinant is not zero
            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = -matrix[0, 1] / determinant;
            inverse[1, 0] = -matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;

            return inverse;
        }

        // Method to find the inverse of a 3x3 matrix
        public static double[,] FindInverse3x3(double[,] matrix)
        {
            double determinant = FindDeterminant3x3(matrix);
            double[,] inverse = new double[3, 3];

            // Calculating cofactor matrix and dividing by determinant
            inverse[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / determinant;
            inverse[0, 1] = -(matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1]) / determinant;
            inverse[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / determinant;

            inverse[1, 0] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) / determinant;
            inverse[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / determinant;
            inverse[1, 2] = -(matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0]) / determinant;

            inverse[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / determinant;
            inverse[2, 1] = -(matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0]) / determinant;
            inverse[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / determinant;

            return inverse;
        }

        // Method to display a matrix
        public static void DisplayMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
