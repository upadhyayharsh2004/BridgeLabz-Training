using System;
class PowerOfANumber{
    public static void Main(string[] args){
        // Read the number entered by the user and getting integer input value for a variable named number
        int number = Convert.ToInt32(Console.ReadLine());
        // Read the number entered by the user and getting integer input value for a variable named power
        int power = Convert.ToInt32(Console.ReadLine());
        //Creating a result variable with an initial value of 1.
        int result=1;
        //Running a for loop from i = 1 to i = power where power is taken input by user
        for(int i=1;i<=power;i++){
            //In each iteration of the loop, multiply the result with the number and assign the value to the result.
            result*=number;
        }
        //Printing the result to the output screen after multiplying the number with the result
        Console.WriteLine(result);
    }
}