using System;
class LargestOf3Numbers{
    public static void Main(string[]args){
        //taking integer number1 as input 
        int number1=Convert.ToInt32(Console.ReadLine());
        //taking integer number2 as input 
        int number2=Convert.ToInt32(Console.ReadLine());
        //taking integer number3 as input 
        int number3=Convert.ToInt32(Console.ReadLine());
        //checking that the which number out of 3 numbers is the largest
        if(number1>number2 && number1>number3){
            //printing that is the first number the largest of 3 numbers:Yes
            Console.WriteLine("Is the first number the largest? "+" "+"Yes");
        }
        else if(number1<number2 || number1<number3){
            //printing that is the first number the largest of 3 numbers:No
            Console.WriteLine("Is the first number the largest? "+" "+"No");
        }
        else if(number2>number1 && number2>number3){
            //printing that is the second number the largest of 3 numbers:Yes
            Console.WriteLine("Is the second number the largest? "+" "+"Yes");
        }
        else if(number2<number1 || number2<number3){
            //printing that is the second number the largest of 3 numbers:No
            Console.WriteLine("Is the second number the largest? "+" "+"No");
        }
        else if(number2<number1 || number2<number3){
            //printing that is the third number the largest of 3 numbers:Yes
            Console.WriteLine("Is the second number the largest? "+" "+"No");
        }
        else if(number3>number1 && number3>number2){
            //printing that is the third number the largest of 3 numbers:No
            Console.WriteLine("Is the third number the largest? "+" "+"Yes");
        }
    }
}