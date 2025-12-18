using System;
namespace package{
    internal class CelsiusToFahrenheitConverter{
        public static double ToFahrenheit(double c){
            return (c * 9 / 5) + 32;
        }
        public static void Main(string[] args){
            double temp = Convert.ToDouble(Console.ReadLine());
            double result = ToFahrenheit(temp);
            Console.WriteLine("Fahrenheit: " + result);
        }
    }
}
