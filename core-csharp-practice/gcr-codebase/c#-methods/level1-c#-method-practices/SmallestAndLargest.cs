using System;


namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class SmallestAndLargest
   {
       public static void Main(string[] args)
       {
           //Taking user input for 3 number for checking of smallest and largest number out of 3
           int firstNumber = Convert.ToInt32(Console.ReadLine());
           int secondNumber = Convert.ToInt32(Console.ReadLine());
           int thirdNumber = Convert.ToInt32(Console.ReadLine());
           //Creating an instance or object of the class to access non static method in a static method
           SmallestAndLargest sL=new SmallestAndLargest();
           //Calling a method to check smallest and largest number out of 3 and storing it in a array to print further
           int[] checkedArray = FindSmallestAndLargest(firstNumber, secondNumber, thirdNumber);
           Console.WriteLine("The Smallest Number is the" + " " + checkedArray[1] + " " + "And the Largest Number is the" + " " + checkedArray[0]);
       }
       public static int[] FindSmallestAndLargest(int firstNumber, int secondNumber, int thirdNumber)
       {
           int[] array = new int[2];
           if (firstNumber>secondNumber && firstNumber>thirdNumber)
           {
               array[0] = firstNumber;
           }
           else if (firstNumber <secondNumber && secondNumber> thirdNumber)
           {
               array[0] = secondNumber;
           }
           else if (firstNumber < thirdNumber && secondNumber<thirdNumber)
           {
               array[0] = thirdNumber;
           }
           if (firstNumber < secondNumber && secondNumber<thirdNumber)
           {
               array[1] = firstNumber;
           }
           else if (firstNumber>secondNumber && secondNumber < thirdNumber)
           {
               array[1] = secondNumber;
           }
           else if (firstNumber>thirdNumber && secondNumber>thirdNumber)
           {
               array[1] = thirdNumber;
           }
           return array;
       }
   }
}
