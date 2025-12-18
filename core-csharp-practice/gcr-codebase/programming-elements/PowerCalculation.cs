using System;
namespace package{
    internal class PowerCalculation{
        public static void Main(string[] args) {
            double baseValue=Convert.ToDouble(Console.ReadLine());
            double exponent=Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(baseValue, exponent);
            Console.WriteLine(result);
        }
    }
}