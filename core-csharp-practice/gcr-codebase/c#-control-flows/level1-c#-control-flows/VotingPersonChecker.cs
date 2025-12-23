using System;
class VotingPersonChecker{
    public static void Main(string[]args){
        //taking integer age as input as a variable
        int age=Convert.ToInt32(Console.ReadLine());
        //checking that the person's age or person is eligible to vote or not
        if(age>=18){
            //printing that the what's the person age is and he can vote also
            Console.WriteLine("The person's age is"+" "+age+" "+"and can vote.");
        }
        else{
            //printing that the what's the person age is and he cannot vote
            Console.WriteLine("The person's age is"+" "+age+" "+"and cannot vote.");
        }
    }
}