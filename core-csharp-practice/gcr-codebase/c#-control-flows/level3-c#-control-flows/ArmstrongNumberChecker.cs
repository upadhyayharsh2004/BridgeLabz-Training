using System;
class ArmstrongNumberChecker{
    public static void Main(string[] args){
        //Read the number entered by the user and get an integer input for the number variable.
        int number = Convert.ToInt32(Console.ReadLine());
        //Defining and Creating an integer variable sum with 0 intial value
        int sum=0;
        //Creating an Original Number variable and assigning it to the input number variable
        int originalNumber=number;
        //Using a while loop till the originalNumber variable data doesn't become zero
        while(number!=0){
            //access each digit using remainder operator for armstrong number checker
            int remainder=number%10;
            //adding cube of value of remainder value into sum variable 
            sum+=(remainder*remainder*remainder);
            //find the quotient of the number and assign it to the original number using number / 10 expression
            number=number/10;
        }
        if(originalNumber==sum){
            //Printing the Armstrong Number to the output if it is 
            Console.WriteLine("Armstrong Number");
        }
        else{
            //Printing the Not an Armstrong Number to the output if it is not
            Console.WriteLine("Not an Armstrong Number");
        }
    }
}