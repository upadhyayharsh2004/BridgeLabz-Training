using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class SumOfNaturalNumbers
    {
        public static void Main(string[] args)
        {
            //Take the user input number and check whether it's a Natural number, if not exit
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("The Number" + " " + number + " " + "Is A Natural Number");
            }
            else
            {
                Console.WriteLine("The Number" + " " + number + " " + "Is Not A Natural Number");
                Environment.Exit(0);
            }
            SumOfNaturalNumbers sN = new SumOfNaturalNumbers();
            int resultOfSum = sN.SumUsingRecursion(number);
            int sumUsingFormula = sN.SumUsingFormula(number);
            Console.WriteLine(resultOfSum);
            Console.WriteLine(sumUsingFormula);
            if (resultOfSum == sumUsingFormula)
            {
                Console.WriteLine("Both computations are correct and results are equal");
            }
            else
            {
                Console.WriteLine("Results are not equal");
            }
        }
        public int SumUsingRecursion(int n)
        {
            // Base condition for recursion
            if (n == 1)
            {
                return 1;
            }
            // Recursive call
            return n + SumUsingRecursion(n - 1);
        }
        public int SumUsingFormula(int n)
        {
            // Applying the formula to calculate sum
            int sum = n * (n + 1) / 2;
            // Returning the calculated sum
            return sum;
        }
    }
}
