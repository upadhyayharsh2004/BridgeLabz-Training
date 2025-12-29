using System;
namespace package{
	internal class Palindrome{
		public static void Main(string[]args){
		    int x=Convert.ToInt32(Console.ReadLine());
		    int total = 0;
		    int k = x;
            while(x > 0){
                int b = x%10;
                total = total*10 + b;
                x = x/10;
            }
            if(total == k){
                Console.WriteLine("true");
            }
            else{
                Console.WriteLine("false");
            }
		}
	}
}
