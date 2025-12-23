using System;
class HarshadNumberChecker{
    public static void Main(string[] args){
        // Read the number entered by the user
        int number = Convert.ToInt32(Console.ReadLine());
        //Creating an integer variable sum with 0 intial value
        int sum=0;
        //Using a while loop to access each digit of a number given by user and checking that number is not equal to 0
        while(number!=0){
            //access each digit using remainder operator
            int remainder=number%10;
            //adding value of remainder to the sum variable
            sum+=remainder;
            //updating the number with quotient of that number using division opertor
            number=number/10;
        }
        if(number%sum==0){
            //Printing the Harshad Number to the output 
            Console.WriteLine("Harshad Number");
        }
        else{
            //Printing the Not a Harshad Number to the output
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
