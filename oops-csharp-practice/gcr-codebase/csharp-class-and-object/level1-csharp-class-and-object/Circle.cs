using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_and_object.level_1
{
    internal class Circle
    {
        //attribute to store data
        double radius;

        public static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.Write("ENTER RADIUS: ");
            circle.radius = Convert.ToDouble(Console.ReadLine());
            circle.CalculateArea();
            circle.CalculateCircumference();

        }
        public void CalculateArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle: " + area);
        }
        public void CalculateCircumference()
        {

            double circumference = 2 * Math.PI * radius;
            Console.WriteLine("Circumference of circle: " + circumference);
        }
    }
}