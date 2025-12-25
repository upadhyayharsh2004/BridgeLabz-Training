using System;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class TrigonometricFunctions
   {
       public static void Main(string[] args)
       {
           // Taking user input for angle in degrees
           double angle=Convert.ToDouble(Console.ReadLine());
           // Creating an object of the class to access the method
           TrigonometricFunctions trig=new TrigonometricFunctions();
           // Calling the method to calculate trigonometric functions
           double[]result=trig.calculateTrigonometricFunctions(angle);
           // Displaying the sine, cosine and tangent values
           Console.WriteLine("Sine Value="+result[0]);
           Console.WriteLine("Cosine Value="+result[1]);
           Console.WriteLine("Tangent Value="+result[2]);
       }
       // Method to calculate various trigonometric functions
       public double[] calculateTrigonometricFunctions(double angle)
       {
           // Creating an array to store sine, cosine and tangent values
           double[]values=new double[3];
           // Converting angle from degrees to radians
           double radians=angle*Math.PI / 180;
           // Calculating sine of the angle
           values[0]=Math.Sin(radians);
           // Calculating cosine of the angle
           values[1]=Math.Cos(radians);
           // Calculating tangent of the angle
           values[2]=Math.Tan(radians);
           // Returning the calculated trigonometric values
           return values;
       }
   }
}
