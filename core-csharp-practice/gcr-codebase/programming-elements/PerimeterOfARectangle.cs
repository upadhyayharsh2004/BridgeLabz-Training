using System;
namespace package{
    internal class PerimeterOfARectangle{
        public static void Main(string[]args){
            float length=Convert.ToSingle(Console.ReadLine());
            float width=Convert.ToSingle(Console.ReadLine());
            float Perimeter=2*(length+width);
            Console.WriteLine(Perimeter);
        }
    }
}