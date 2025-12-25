using System;
namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class UnitConvertor
    {
        public static void Main(string[] args)
        {
            // Taking user input for kilometers
            double kilometers = Convert.ToDouble(Console.ReadLine());
            // Converting kilometers to miles using static method
            double miles = ConvertKmToMiles(kilometers);
            Console.WriteLine("Kilometers to Miles = " + miles);
            // Taking user input for miles
            double milesInput = Convert.ToDouble(Console.ReadLine());
            // Converting miles to kilometers using static method
            double kilometersResult = ConvertMilesToKm(milesInput);
            Console.WriteLine("Miles to Kilometers = " + kilometersResult);
            // Taking user input for meters
            double meters = Convert.ToDouble(Console.ReadLine());
            // Converting meters to feet using static method
            double feet = ConvertMetersToFeet(meters);
            Console.WriteLine("Meters to Feet = " + feet);
            // Taking user input for feet
            double feetInput = Convert.ToDouble(Console.ReadLine());
            // Converting feet to meters using static method
            double metersResult = ConvertFeetToMeters(feetInput);
            Console.WriteLine("Feet to Meters = " + metersResult);
        }
        // Method to convert kilometers to miles and return the value
        public static double ConvertKmToMiles(double km)
        {
            // Conversion value for kilometers to miles
            double km2miles = 0.621371;
            // Calculating miles from kilometers
            double miles = km * km2miles;
            // Returning the converted value
            return miles;
        }
        // Method to convert miles to kilometers and return the value
        public static double ConvertMilesToKm(double miles)
        {
            // Conversion value for miles to kilometers
            double miles2km = 1.60934;
            // Calculating kilometers from miles
            double km = miles * miles2km;
            // Returning the converted value
            return km;
        }
        // Method to convert meters to feet and return the value
        public static double ConvertMetersToFeet(double meters)
        {
            // Conversion value for meters to feet
            double meters2feet = 3.28084;
            // Calculating feet from meters
            double feet = meters * meters2feet;
            // Returning the converted value
            return feet;
        }
        // Method to convert feet to meters and return the value
        public static double ConvertFeetToMeters(double feet)
        {
            // Conversion value for feet to meters
            double feet2meters = 0.3048;
            // Calculating meters from feet
            double meters = feet * feet2meters;
            // Returning the converted value
            return meters;
        }
    }
}
