using System;
class EmployeeBonus{
    public static void Main(string[] args){
        double salary = Convert.ToDouble(Console.ReadLine()); // Read salary
        int years = Convert.ToInt32(Console.ReadLine()); // Read years of service
        // Variable to store bonus amount
        double bonus = 0;
        // Check if employee has more than 5 years of service
        if (years > 5){
            // Calculate 5% bonus
            bonus = salary * 0.05;
        }
        // Print the bonus amount
        Console.WriteLine("Bonus Amount: " + bonus);
    }
}
