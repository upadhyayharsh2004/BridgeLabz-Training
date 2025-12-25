using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class NumberChecker
    {
        public static void Main(string[] args)
        {
            // Taking user input for the number
            int number=Convert.ToInt32(Console.ReadLine());
            // Calling method to find the count of digits
            int digitCount=CountDigits(number);
            Console.WriteLine("Number of Digits="+digitCount);
            // Calling method to store digits of the number in an array
            int[] digits=StoreDigits(number,digitCount);
            // Calling method to check whether the number is a Duck number
            bool isDuck=IsDuckNumber(digits);
            Console.WriteLine("Is Duck Number="+isDuck);
            // Calling method to check whether the number is an Armstrong number
            bool isArmstrong=IsArmstrongNumber(number,digits);
            Console.WriteLine("Is Armstrong Number="+isArmstrong);
            // Calling method to find largest and second largest digits
            int[] largestResult=FindLargestAndSecondLargest(digits);
            Console.WriteLine("Largest Digit="+largestResult[0]);
            Console.WriteLine("Second Largest Digit="+largestResult[1]);
            // Calling method to find smallest and second smallest digits
            int[] smallestResult=FindSmallestAndSecondSmallest(digits);
            Console.WriteLine("Smallest Digit="+smallestResult[0]);
            Console.WriteLine("Second Smallest Digit="+smallestResult[1]);
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
        // Method to check if a number is a Duck number using the digits array
        // Duck number contains at least one non-zero digit
        public static bool IsDuckNumber(int[]digits)
        {
            for (int i=0;i<digits.Length;i++)
            {
                if (digits[i]!=0)
                {
                    return true;
                }
            }
            return false;
        }
        // Method to check if the number is an Armstrong number using the digits array
        public static bool IsArmstrongNumber(int number,int[]digits)
        {
            int sum=0;
            int power=digits.Length;
            for (int i=0;i<digits.Length;i++)
            {
                sum +=(int)Math.Pow(digits[i],power);
            }
            return sum==number;
        }
        // Method to find the largest and second largest elements in the digits array
        public static int[] FindLargestAndSecondLargest(int[]digits)
        {
            int largest=Int32.MinValue;
            int secondLargest=Int32.MinValue;
            for (int i=0;i<digits.Length;i++)
            {
                if (digits[i]>largest)
                {
                    secondLargest=largest;
                    largest=digits[i];
                }
                else if (digits[i]>secondLargest&&digits[i]!=largest)
                {
                    secondLargest=digits[i];
                }
            }
            return new int[]{largest,secondLargest};
        }
        // Method to find the smallest and second smallest elements in the digits array
        public static int[] FindSmallestAndSecondSmallest(int[]digits)
        {
            {
                int smallest=Int32.MaxValue;
                int secondSmallest=Int32.MaxValue;
                for (int i=0;i<digits.Length;i++)
                {
                    if (digits[i]<smallest)
                    {
                        secondSmallest=smallest;
                        smallest=digits[i];
                    }
                    else if (digits[i]<secondSmallest&&digits[i]!=smallest)
                    {
                        secondSmallest=digits[i];
                    }
                }
                return new int[]{smallest,secondSmallest};
            }
        }
    }
}