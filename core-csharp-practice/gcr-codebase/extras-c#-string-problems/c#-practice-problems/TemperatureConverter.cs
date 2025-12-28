using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.extras_built_in_problems
{
    internal class TemperatureConverter
    {
        public static void Main()
        {
            // Display menu options to the user
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("Enter your choice (1 or 2):");
            int choice=Convert.ToInt32(Console.ReadLine());
            // Perform conversion based on user choice
            if(choice==1)
            {
                // Get Fahrenheit temperature from user
                Console.WriteLine("Enter temperature in Fahrenheit:");
                double fahrenheit=Convert.ToDouble(Console.ReadLine());
                // Convert Fahrenheit to Celsius
                double celsius=FahrenheitToCelsius(fahrenheit);
                // Display result
                Console.WriteLine("Temperature in Celsius:"+celsius);
            }
            else if (choice==2)
            {
                // Get Celsius temperature from user
                Console.WriteLine("Enter temperature in Celsius:");
                double celsius=Convert.ToDouble(Console.ReadLine());
                // Convert Celsius to Fahrenheit
                double fahrenheit=CelsiusToFahrenheit(celsius);
                // Display result
                Console.WriteLine("Temperature in Fahrenheit:"+fahrenheit);
            }
            else
            {
                // Handle invalid choice
                Console.WriteLine("Invalid choice.");
            }
        }
        // Function to convert Fahrenheit to Celsius
        // Parameter:double fahrenheit-temperature in Fahrenheit
        // Return type:double-temperature in Celsius
        static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius=(fahrenheit-32)*5/9;
            return celsius;
        }
        // Function to convert Celsius to Fahrenheit
        // Parameter:double celsius-temperature in Celsius
        // Return type: double-temperature in Fahrenheit
        static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit=(celsius*9/5)+32;
            return fahrenheit;
        }
    }
}
