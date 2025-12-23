using System;
class NumberChecker{
    public static void Main(string[]args){
        //taking integer number as input as a variable
        int number=Convert.ToInt32(Console.ReadLine());
        //checking that the number is positive,negative,or zero
        if(number>0){
            //printing that the number is positive
            Console.WriteLine("positive");
        }
        else if(number<0){
            //printing that the number is negative
            Console.WriteLine("negative");
        }
        else{
            //printing that the number is zero
            Console.WriteLine("zero");
        }
    }
}