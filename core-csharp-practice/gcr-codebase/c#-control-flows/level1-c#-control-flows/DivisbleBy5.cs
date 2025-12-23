using System;
class DivisbleBy5{
    public static void Main(string[]args){
        //taking integer as input as a variable
        int number=Convert.ToInt32(Console.ReadLine());
        //checking that the number is divisble by 5 or not using if-else
        if((number%5)==0){
            //printing that is the number divisble by 5:Yes
            Console.WriteLine("Is the number"+" "+number+" "+"divisble by 5?"+" "+"Yes");
        }
        else if(number%5!=0){
            //printing that is the number divisble by 5:No
            Console.WriteLine("Is the number"+" "+number+" "+"divisble by 5?"+" "+"No");
        }
    }
}