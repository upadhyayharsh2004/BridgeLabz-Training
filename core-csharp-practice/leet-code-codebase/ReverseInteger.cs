using System;
namespace package{
    internal class ReverseInteger{
        public static void Main(string[]args) {
            int x=Convert.ToInt32(Console.ReadLine());
            long output = 0;
            while(x!=0){
                int digit=x%10;
                output+=digit;
                x/=10;
                output *=10;
            }
            output/=10;
            Console.WriteLine((int)output);
        }
    }
}