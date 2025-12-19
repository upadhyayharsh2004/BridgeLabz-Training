using System;
class TemperatureConverter{
    public static void Main(string[] args){
        double celsius;
        celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheitResult = (celsius * (9.0 / 5.0)) + 32;
        Console.WriteLine("The"+" "+celsius+" "+"Celsius is"+" "+fahrenheitResult+" "+"Fahrenheit");
    }
}
