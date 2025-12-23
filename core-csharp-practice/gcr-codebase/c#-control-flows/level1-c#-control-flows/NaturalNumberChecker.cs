using System;
class NaturalNumberChecker{
    public static void Main(string[]args){
        //taking integer number as input 
        int number=Convert.ToInt32(Console.ReadLine());
        //checking that the number is a positive number
        if(number>=0){
            //calculating the sum of n natural numbers 
            int sumOfNaturalNumbers=(number*(number+1)/2);
            //printing the sum of n natural numbers 
            Console.WriteLine("The sum of"+" "+number+" "+"natural numbers is"+" "+sumOfNaturalNumbers);
        }
        else{
            // printing that this is not a natural number
            Console.WriteLine("The number"+" "+number+" "+"is not a natural number");
        }
    }
}