using System;
namespace package{
	internal class CalculateSimpleInterest{
		public static void Main(string[]args){
			double principal=Convert.ToDouble(Console.ReadLine());
			double rate=Convert.ToDouble(Console.ReadLine());
			float time =Convert.ToSingle(Console.ReadLine());
			double SimpleInterest=(principal*rate*time)/100;
			Console.WriteLine(SimpleInterest);
		}
    }
}