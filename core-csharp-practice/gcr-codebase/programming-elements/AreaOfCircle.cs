using System;
namespace package{
	internal class AreaOfCircle{
		public static void Main(string[]args){
			double radius=Convert.ToDouble(Console.ReadLine());
			double area=3.14*radius*radius;
			Console.WriteLine(area);
		}
	}
}