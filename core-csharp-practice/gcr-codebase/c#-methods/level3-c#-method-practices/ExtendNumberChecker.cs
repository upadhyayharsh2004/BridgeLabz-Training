using System;
namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class ExtendNumberChecker
    {
        public static void Main(string[] args)
        {
            // Taking user input for the number
            int number=Convert.ToInt32(Console.ReadLine());
            // Calling method to find the count of digits in the number
            int digitCount=CountDigits(number);
            Console.WriteLine("Digit Count="+digitCount);
            // Calling method to store digits of the number in an array
            int[]digits=StoreDigits(number,digitCount);
            // Calling method to find the sum of digits
            int sumOfDigits=SumOfDigits(digits);
            Console.WriteLine("Sum of Digits="+sumOfDigits);
            // Calling method to find the sum of squares of digits
            int sumOfSquares=SumOfSquaresOfDigits(digits);
            Console.WriteLine("Sum of Squares of Digits="+sumOfSquares);
            // Calling method to check whether the number is a Harshad number
            bool isHarshad=IsHarshadNumber(number,sumOfDigits);
            Console.WriteLine("Is Harshad Number="+isHarshad);
            // Calling method to find frequency of each digit
            int[,] frequency=FindDigitFrequency(digits);
            // Displaying the frequency of each digit
            for (int i=0;i<frequency.GetLength(0);i++)
            {
                if (frequency[i,1]>0)
                {
                    Console.WriteLine("Digit"+frequency[i,0]+"="+frequency[i,1]);
                }
            }
        }
        // Method to find the count of digits in the number
        public static int CountDigits(int number)
        {
            int count=0;
            while (number!=0)
            {
                count++;
                number=number/10;
            }
            return count;
        }
        // Method to store the digits of the number in a digits array
        public static int[] StoreDigits(int number,int digitCount)
        {
            int[]digits=new int[digitCount];
            int index=0;
            while (number!=0)
            {
                digits[index]=number%10;
                number=number/10;
                index++;
            }
            return digits;
        }
        // Method to find the sum of the digits of a number using the digits array
        public static int SumOfDigits(int[]digits)
        {
            int sum=0;
            for (int i=0;i<digits.Length;i++)
            {
                sum+=digits[i];
            }
            return sum;
        }
        // Method to find the sum of the squares of the digits of a number
        public static int SumOfSquaresOfDigits(int[]digits)
        {
            int sum=0;
            for (int i=0;i<digits.Length;i++)
            {
                sum+=(int)Math.Pow(digits[i],2);
            }
            return sum;
        }
        // Method to check if a number is a Harshad number
        public static bool IsHarshadNumber(int number,int sumOfDigits)
        {
            if(sumOfDigits==0)
            {
                return false;
            }
            if(number%sumOfDigits==0)
            {
                return true;
            }
            return false;
        }
        // Method to find the frequency of each digit in the number
        // First column stores digit, second column stores frequency
        public static int[,] FindDigitFrequency(int[]digits)
        {
            int[,]frequency=new int[10,2];
            // Initializing digit values in the first column
            for (int i=0;i<10;i++)
            {
                frequency[i,0]=i;
                frequency[i,1]=0;
            }
            // Calculating frequency of each digit
            for (int i=0;i<digits.Length;i++)
            {
                frequency[digits[i],1]++;
            }
            return frequency;
        }
    }
}
