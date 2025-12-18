using System;
namespace package{
    internal class VolumeOfCylinder{
        public static void Main(string[]args){
            double radius=Convert.ToDouble(Console.ReadLine());;
            double height=Convert.ToDouble(Console.ReadLine());;
            double Volume=3.14*radius*radius*height;
            Console.WriteLine(Volume);
        }
    }
}
