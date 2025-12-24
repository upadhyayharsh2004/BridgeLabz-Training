using System;

namespace BridgeLabzTraining
{
    internal class BonusEmployees
    {
        public static void Main(string[] args)
        {
            // Define a double array to save salary for each of the 10 employees
            double[] sal = new double[10];
            // Define a double array to save years of service for each of the 10 employees
            double[] yearsOfService = new double[10];
            // Define a double array to save the bonus amount for each employee
            double[] bonus = new double[10];
            // Define a double array to save the new salary for each employee
            double[] newSalary = new double[10];
            // Define variables to save the total bonus, total old salary, and total new salary
            double totalBonus = 0.0;
            double totalOldSalary = 0.0;
            double totalNewSalary = 0.0;
            // Define a loop to take input from the user for 10 employees
            for (int i = 0; i < 10; i++)
            {
                // Taking salary input from the user
                double enteredSalary = Convert.ToDouble(Console.ReadLine());
                // Taking years of service input from the user
                double enteredYears = Convert.ToDouble(Console.ReadLine());
                // If salary or year of service is an invalid number then ask the user to enter again
                if (enteredSalary <= 0 || enteredYears < 0)
                {
                    // Decrement the index counter to re-enter the details
                    i--;
                    continue;
                }
                // Save valid salary and years of service in arrays
                sal[i] = enteredSalary;
                yearsOfService[i] = enteredYears;
            }
            // Define another loop to calculate the bonus of 10 employees
            for (int i = 0; i < 10; i++)
            {
                // Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years
                if (yearsOfService[i] > 5)
                {
                    bonus[i] = sal[i] * 0.05;
                }
                // Or 2% if less than or equal to 5 years
                else
                {
                    bonus[i] = sal[i] * 0.02;
                }
                // Compute the new salary and save it in the array
                newSalary[i] = sal[i] + bonus[i];
                // Calculate the total bonus payout
                totalBonus = totalBonus + bonus[i];
                // Calculate the total old salary
                totalOldSalary = totalOldSalary + sal[i];
                // Calculate the total new salary
                totalNewSalary = totalNewSalary + newSalary[i];
            }
            // Print the total bonus payout
            Console.WriteLine("Total Bonus Amount Paid by Zara=" + totalBonus);
            // Print the total old salary of all employees
            Console.WriteLine("Total Old Salary of All Employees=" + totalOldSalary);
            // Print the total new salary of all employees
            Console.WriteLine("Total New Salary of All Employees=" + totalNewSalary);
        }
    }
}
