using System;
class TemperatureConversion{
    public static void Main(string[] args){
        double fahrenheit;
        fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsiusResult = (fahrenheit - 32) * (5.0 / 9.0);
        Console.WriteLine(
            "The"+" "+fahrenheit+" "+"Fahrenheit is"+" "+celsiusResult+" "+"Celsius");
    }
}
