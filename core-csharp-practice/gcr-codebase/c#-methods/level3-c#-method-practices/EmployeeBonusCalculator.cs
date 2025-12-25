using System;

namespace BridgeLabzTraining.level3_c__methods_practices
{
    internal class EmployeeBonusCalculator
    {
        public static void Main(string[] args)
        {
            // Defining number of employees
            int employees = 10;

            // Calling method to generate salary and years of service for employees
            double[,] employeeData = GenerateSalaryAndService(employees);

            // Calling method to calculate bonus and new salary
            double[,] updatedSalaryData = CalculateBonusAndNewSalary(employeeData);

            // Calling method to calculate totals and display results in tabular format
            DisplaySalarySummary(employeeData, updatedSalaryData);
        }

        // Method to determine the Salary and years of service and return the same
        // Uses Math.Random() to generate 5-digit salary and random years of service
        // 2D Array Column 0 -> Salary, Column 1 -> Years of Service
        public static double[,] GenerateSalaryAndService(int employees)
        {
            double[,] data = new double[employees, 2];
            Random random = new Random();

            for (int i = 0; i < employees; i++)
            {
                // Generating random 5-digit salary
                data[i, 0] = random.Next(10000, 100000);

                // Generating random years of service between 1 and 10
                data[i, 1] = random.Next(1, 11);
            }

            return data;
        }

        // Method to calculate the new salary and bonus based on years of service
        // Returns a new 2D array where
        // Column 0 -> Bonus Amount, Column 1 -> New Salary
        public static double[,] CalculateBonusAndNewSalary(double[,] employeeData)
        {
            int employees = employeeData.GetLength(0);
            double[,] result = new double[employees, 2];

            for (int i = 0; i < employees; i++)
            {
                double salary = employeeData[i, 0];
                double years = employeeData[i, 1];
                double bonus;

                // Bonus calculation logic
                if (years > 5)
                {
                    bonus = salary * 0.05;
                }
                else
                {
                    bonus = salary * 0.02;
                }

                // Storing bonus and new salary
                result[i, 0] = bonus;
                result[i, 1] = salary + bonus;
            }

            return result;
        }

        // Method to calculate the sum of Old Salary, New Salary, and Total Bonus
        // Displays the result in a tabular format
        public static void DisplaySalarySummary(double[,] oldData, double[,] newData)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");

            for (int i = 0; i < oldData.GetLength(0); i++)
            {
                double oldSalary = oldData[i, 0];
                double years = oldData[i, 1];
                double bonus = newData[i, 0];
                double newSalary = newData[i, 1];

                totalOldSalary += oldSalary;
                totalBonus += bonus;
                totalNewSalary += newSalary;

                Console.WriteLine(
                    (i + 1) + "\t" +
                    oldSalary + "\t\t" +
                    years + "\t" +
                    bonus + "\t\t" +
                    newSalary
                );
            }

            Console.WriteLine();
            Console.WriteLine("Total Old Salary  = " + totalOldSalary);
            Console.WriteLine("Total Bonus Paid = " + totalBonus);
            Console.WriteLine("Total New Salary = " + totalNewSalary);
        }
    }
}
