using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class OtpGenerator
    {
        public static void Main(string[] args)
        {
            // Creating an array to save the OTP numbers generated 10 times
            int[] otpNumbers = new int[10];

            // Generating 6-digit OTP numbers 10 times
            for (int i = 0; i < otpNumbers.Length; i++)
            {
                otpNumbers[i] = GenerateSixDigitOtp();
            }

            // Displaying the generated OTP numbers
            Console.WriteLine("Generated OTP Numbers:");
            for (int i = 0; i < otpNumbers.Length; i++)
            {
                Console.WriteLine("OTP " + (i + 1) + " = " + otpNumbers[i]);
            }

            // Calling method to check whether all OTP numbers are unique
            bool isUnique = AreOtpsUnique(otpNumbers);

            // Displaying the result
            if (isUnique)
            {
                Console.WriteLine("All generated OTP numbers are unique");
            }
            else
            {
                Console.WriteLine("Duplicate OTP numbers found");
            }
        }

        // Method to Generate a 6-digit OTP number using Math.Random()
        public static int GenerateSixDigitOtp()
        {
            // Generating a random 6-digit number between 100000 and 999999
            int otp = (int)(Math.Random() * 900000) + 100000;
            return otp;
        }

        // Method to ensure that the OTP numbers generated are unique
        // If unique return true else return false
        public static bool AreOtpsUnique(int[] otpNumbers)
        {
            // Comparing each OTP with every other OTP
            for (int i = 0; i < otpNumbers.Length; i++)
            {
                for (int j = i + 1; j < otpNumbers.Length; j++)
                {
                    if (otpNumbers[i] == otpNumbers[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
