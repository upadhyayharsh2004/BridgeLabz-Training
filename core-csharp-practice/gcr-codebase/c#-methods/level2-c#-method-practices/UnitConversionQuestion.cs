using System;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class UnitConversionQuestion
    {
        public static void Main(string[] args)
        {
            // Taking user input for yards
            double yards = Convert.ToDouble(Console.ReadLine());
            // Converting yards to feet using static method
            double feetFromYards = ConvertYardsToFeet(yards);
            Console.WriteLine("Yards to Feet=" + feetFromYards);
            // Taking user input for feet
            double feet = Convert.ToDouble(Console.ReadLine());
            // Converting feet to yards using static method
            double yardsFromFeet = ConvertFeetToYards(feet);
            Console.WriteLine("Feet to Yards=" + yardsFromFeet);
            // Taking user input for meters
            double meters = Convert.ToDouble(Console.ReadLine());
            // Converting meters to inches using static method
            double inchesFromMeters = ConvertMetersToInches(meters);
            Console.WriteLine("Meters to Inches=" + inchesFromMeters);
            // Taking user input for inches
            double inches = Convert.ToDouble(Console.ReadLine());
            // Converting inches to meters using static method
            double metersFromInches = ConvertInchesToMeters(inches);
            Console.WriteLine("Inches to Meters=" + metersFromInches);
            // Converting inches to centimeters using static method
            double centimeters = ConvertInchesToCentimeters(inches);
            Console.WriteLine("Inches to Centimeters=" + centimeters);
        }
        // Method to convert yards to feet and return the value
        public static double ConvertYardsToFeet(double yards)
        {
            // Conversion value for yards to feet
            double yards2feet = 3;
            // Calculating feet from yards
            double feet = yards * yards2feet;
            // Returning the converted value
            return feet;
        }
        // Method to convert feet to yards and return the value
        public static double ConvertFeetToYards(double feet)
        {
            // Conversion value for feet to yards
            double feet2yards = 0.333333;
            // Calculating yards from feet
            double yards = feet * feet2yards;
            // Returning the converted value
            return yards;
        }
        // Method to convert meters to inches and return the value
        public static double ConvertMetersToInches(double meters)
        {
            // Conversion value for meters to inches
            double meters2inches = 39.3701;
            // Calculating inches from meters
            double inches = meters * meters2inches;
            // Returning the converted value
            return inches;
        }
        // Method to convert inches to meters and return the value
        public static double ConvertInchesToMeters(double inches)
        {
            // Conversion value for inches to meters
            double inches2meters = 0.0254;
            // Calculating meters from inches
            double meters = inches * inches2meters;
            // Returning the converted value
            return meters;
        }
        // Method to convert inches to centimeters and return the value
        public static double ConvertInchesToCentimeters(double inches)
        {
            // Conversion value for inches to centimeters
            double inches2cm = 2.54;
            // Calculating centimeters from inches
            double centimeters = inches * inches2cm;
            // Returning the converted value
            return centimeters;
        }
    }
}
