using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.arrays
{
   internal class MultiDimensionalArrays
   {
       private static int i;

       public static void Main(string[] args)
       {
           //Taking user input for rows for 2d array
           int rows = Convert.ToInt32(Console.ReadLine());
           //Taking user input for columns for 2d array
           int columns = Convert.ToInt32(Console.ReadLine());
           //create a 2D array (Matrix) for copy the 2d array to 1d array
           int[,] arrays2d = new int[rows, columns];
           //Taking the user input for the 2d arrays to convert it into 1d arrays
           for (int i = 0; i < arrays2d.GetLength(0); i++)
           {
               //Using Second For loop for accessing the for loop to the columns also
               for (int j = 0; j < arrays2d.GetLength(1); j++)
               {
                   //Taking the user input in the form of rows or columns 2d array form
                   arrays2d[i, j] = Convert.ToInt32(Console.ReadLine());
               }
           }
           //Creating a 1D array of size rows*columns for copy content of 2d array to 1d array
           int[] array = new int[rows * columns];
           //Defining the index variable for the 2d array to 1d array copy content
           int index = 0;
           for (int i = 0; i < arrays2d.GetLength(0); i++)
           {
               //Using Second For loop for accessing the for loop to the columns also
               for (int j = 0; j < arrays2d.GetLength(1); j++)
               {
                   //Copying every element of the 2D array into the 1D array and increment the index
                   array[index] = arrays2d[i, j];
                   index++;
               }
           }
           // Display the 1D array
           for (i = 0; i < array.Length; i++)
           {
               //Printing the content of 1d array to the console or output screen
               Console.Write(array[i] + " ");
           }
       }
   }
}
