using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class Factors
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] resultOfFactors = FactorNumbers(number);
            Factors f = new Factors();
            int sumOfFactors = f.FactorsSum(resultOfFactors);
            int productOfFactors = f.FactorsProducts(resultOfFactors);
            int powerOfFactors = f.FactorsPower(resultOfFactors);
            for (int i = 0; i < resultOfFactors.Length; i++)
            {
                Console.WriteLine(resultOfFactors[i] + " ");
            }
            Console.WriteLine(sumOfFactors + " ");
            Console.WriteLine(productOfFactors + " ");
            Console.WriteLine(powerOfFactors + " ");
        }
        //Write a static Method to find the factors of the number and save them in an array and return the array. 
        public static int[] FactorNumbers(int factor)
        {
            int count = 0;
            for (int i = 1; i <= factor; i++)
            {
                if (factor % i == 0)
                {
                    count++;
                }
            }
            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= factor; i++)
            {
                if (factor % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }
        public int FactorsSum(int[] factorArray)
        {
            int sum = 0;
            for (int i = 0; i < factorArray.Length; i++)
            {
                sum += factorArray[i];
            }
            return sum;
        }
        public int FactorsProducts(int[] factorArray)
        {
            int product = 1;
            for (int i = 0; i < factorArray.Length; i++)
            {
                product *= factorArray[i];
            }
            return product;

        }
        public int FactorsPower(int[] factorArray)
        {
            int sum = 0;
            for (int i = 0; i < factorArray.Length; i++)
            {
                sum = sum + (factorArray[i] * factorArray[i]);
            }
            return sum;
        }
    }
}
