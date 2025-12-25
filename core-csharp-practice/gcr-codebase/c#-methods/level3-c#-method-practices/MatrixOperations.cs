using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class MatrixOperations
    {
        public static void Main(string[] args)
        {
            // Defining number of rows and columns for matrices
            int rows = 2;
            int columns = 2;

            // Creating two random matrices
            int[,] matrixA = CreateRandomMatrix(rows, columns);
            int[,] matrixB = CreateRandomMatrix(rows, columns);

            // Displaying Matrix A
            Console.WriteLine("Matrix A:");
            PrintMatrix(matrixA);

            // Displaying Matrix B
            Console.WriteLine("Matrix B:");
            PrintMatrix(matrixB);

            // Adding two matrices
            int[,] additionResult = AddMatrices(matrixA, matrixB);
            Console.WriteLine("Addition of Matrix A and B:");
            PrintMatrix(additionResult);

            // Subtracting two matrices
            int[,] subtractionResult = SubtractMatrices(matrixA, matrixB);
            Console.WriteLine("Subtraction of Matrix A and B:");
            PrintMatrix(subtractionResult);

            // Multiplying two matrices
            int[,] multiplicationResult = MultiplyMatrices(matrixA, matrixB);
            Console.WriteLine("Multiplication of Matrix A and B:");
            PrintMatrix(multiplicationResult);

            // Finding transpose of Matrix A
            int[,] transposeResult = TransposeMatrix(matrixA);
            Console.WriteLine("Transpose of Matrix A:");
            PrintMatrix(transposeResult);

            // Finding determinant of Matrix A
            int determinant = FindDeterminant(matrixA);
            Console.WriteLine("Determinant of Matrix A = " + determinant);

            // Finding inverse of Matrix A if determinant is not zero
            if (determinant != 0)
            {
                double[,] inverseMatrix = FindInverse(matrixA);
                Console.WriteLine("Inverse of Matrix A:");
                PrintDoubleMatrix(inverseMatrix);
            }
            else
            {
                Console.WriteLine("Inverse of Matrix A does not exist");
            }
        }

        // Method to create a random matrix taking rows and columns as parameters
        public static int[,] CreateRandomMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            return matrix;
        }

        // Method to add two matrices
        public static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return result;
        }

        // Method to subtract two matrices
        public static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }

            return result;
        }

        // Method to multiply two matrices
        public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rows = matrixA.GetLength(0);
            int columns = matrixB.GetLength(1);
            int common = matrixA.GetLength(1);

            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < common; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return result;
        }

        // Method to find transpose of a matrix
        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] transpose = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }

            return transpose;
        }

        // Method to find determinant of a 2x2 matrix
        public static int FindDeterminant(int[,] matrix)
        {
            int determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return determinant;
        }

        // Method to find inverse of a 2x2 matrix
        public static double[,] FindInverse(int[,] matrix)
        {
            double[,] inverse = new double[2, 2];
            int determinant = FindDeterminant(matrix);

            inverse[0, 0] = matrix[1, 1] / (double)determinant;
            inverse[0, 1] = -matrix[0, 1] / (double)determinant;
            inverse[1, 0] = -matrix[1, 0] / (double)determinant;
            inverse[1, 1] = matrix[0, 0] / (double)determinant;

            return inverse;
        }

        // Method to print an integer matrix
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Method to print a double matrix
        public static void PrintDoubleMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
