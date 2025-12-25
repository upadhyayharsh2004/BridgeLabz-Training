using System;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class UnitConversionQuestionProblem
    {
        public static void Main(string[] args)
        {
            // Taking user input for temperature in Fahrenheit
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            // Converting Fahrenheit to Celsius using static method
            double celsius = ConvertFahrenheitToCelsius(fahrenheit);
            Console.WriteLine("Fahrenheit to Celsius=" + celsius);
            // Taking user input for temperature in Celsius
            double celsiusInput = Convert.ToDouble(Console.ReadLine());
            // Converting Celsius to Fahrenheit using static method
            double fahrenheitResult = ConvertCelsiusToFahrenheit(celsiusInput);
            Console.WriteLine("Celsius to Fahrenheit=" + fahrenheitResult);
            // Taking user input for weight in pounds
            double pounds = Convert.ToDouble(Console.ReadLine());
            // Converting pounds to kilograms using static method
            double kilograms = ConvertPoundsToKilograms(pounds);
            Console.WriteLine("Pounds to Kilograms=" + kilograms);
            // Taking user input for weight in kilograms
            double kilogramsInput = Convert.ToDouble(Console.ReadLine());
            // Converting kilograms to pounds using static method
            double poundsResult = ConvertKilogramsToPounds(kilogramsInput);
            Console.WriteLine("Kilograms to Pounds=" + poundsResult);
            // Taking user input for volume in gallons
            double gallons = Convert.ToDouble(Console.ReadLine());
            // Converting gallons to liters using static method
            double liters = ConvertGallonsToLiters(gallons);
            Console.WriteLine("Gallons to Liters=" + liters);
            // Taking user input for volume in liters
            double litersInput = Convert.ToDouble(Console.ReadLine());
            // Converting liters to gallons using static method
            double gallonsResult = ConvertLitersToGallons(litersInput);
            Console.WriteLine("Liters to Gallons=" + gallonsResult);
        }
        // Method to convert Fahrenheit to Celsius and return the value
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            // Applying Fahrenheit to Celsius conversion formula
            double farhenheit2celsius = (fahrenheit - 32) * 5 / 9;
            // Returning the converted value
            return farhenheit2celsius;
        }
        // Method to convert Celsius to Fahrenheit and return the value
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            // Applying Celsius to Fahrenheit conversion formula
            double celsius2farhenheit = (celsius * 9 / 5) + 32;
            // Returning the converted value
            return celsius2farhenheit;
        }
        // Method to convert pounds to kilograms and return the value
        public static double ConvertPoundsToKilograms(double pounds)
        {
            // Conversion value for pounds to kilograms
            double pounds2kilograms = 0.453592;
            // Calculating kilograms from pounds
            double kilograms = pounds * pounds2kilograms;
            // Returning the converted value
            return kilograms;
        }
        // Method to convert kilograms to pounds and return the value
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            // Conversion value for kilograms to pounds
            double kilograms2pounds = 2.20462;
            // Calculating pounds from kilograms
            double pounds = kilograms * kilograms2pounds;
            // Returning the converted value
            return pounds;
        }
        // Method to convert gallons to liters and return the value
        public static double ConvertGallonsToLiters(double gallons)
        {
            // Conversion value for gallons to liters
            double gallons2liters = 3.78541;
            // Calculating liters from gallons
            double liters = gallons * gallons2liters;
            // Returning the converted value
            return liters;
        }
        // Method to convert liters to gallons and return the value
        public static double ConvertLitersToGallons(double liters)
        {
            // Conversion value for liters to gallons
            double liters2gallons = 0.264172;
            // Calculating gallons from liters
            double gallons = liters * liters2gallons;
            // Returning the converted value
            return gallons;
        }
    }
}
