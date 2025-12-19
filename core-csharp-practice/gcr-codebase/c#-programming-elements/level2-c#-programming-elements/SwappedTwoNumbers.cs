using System;
class SwappedTwoNumbers{
    public static void Main(string[]args){
        int number1=Convert.ToInt32(Console.ReadLine());
        int number2=Convert.ToInt32(Console.ReadLine());
        int number3=number1;
        number1=number2;
        number2=number3;
        Console.WriteLine("The swapped numbers are"+" "+number1+" "+"and"+" "+number2);
    }
}