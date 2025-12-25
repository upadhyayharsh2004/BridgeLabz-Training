using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class WindChillTemperature
   {
       public static void Main(string[] args)
       {
           //Getting an integer value input from the user for the numberOfchocolates and numberOfChildren
           double temperature = Convert.ToDouble(Console.ReadLine());
           double windSpeed = Convert.ToDouble(Console.ReadLine());
           //Creating an instance or object of the class to access non static method in a static method
           WindChillTemperature wC = new WindChillTemperature();
           //Calling a method to find temperature of the wind with the help of windSpeed and temperatureOfChill variable and storing it in variable to print further
           double temperatureOfWindChill =wC.CalculateWindChill(temperature, windSpeed);
           Console.WriteLine("The Temperature of Wind Chill is" + " " + temperatureOfWindChill);
       }
       public double CalculateWindChill(double temperature, double windSpeed)
       {
           double windChill=35.74+(0.6215*temperature)+(0.4275*temperature-35.75)*Math.Pow(windSpeed, 0.16);
           return windChill;
       }
   }
}
