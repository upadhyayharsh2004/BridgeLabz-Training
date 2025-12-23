using System;

class SmallestOf3Numbers{
    public static void Main(string[]args){
        //taking integer number1 as input 
        int number1=Convert.ToInt32(Console.ReadLine());
        //taking integer number2 as input 
        int number2=Convert.ToInt32(Console.ReadLine());
        //taking integer number3 as input 
        int number3=Convert.ToInt32(Console.ReadLine());
        //checking that the first number number1 is smallest of 3 number or not
        if((number1<number2 && number1<number3) && number2<number3){
            //printing that is the first number smallest of 3 numbers:Yes
            Console.WriteLine("Is the first number the smallest"+" "+"Yes");
        }
        else{
            //printing that is the first number smallest of 3 numbers:No
            Console.WriteLine("Is the first number the smallest"+" "+"No");
        }
    }
}