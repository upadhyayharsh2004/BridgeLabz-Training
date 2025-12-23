using System;
class AbundantNumberChecker{
    public static void Main(string[] args){
        //Read the number entered by the user and get an integer input for the number variable.
        int number = Convert.ToInt32(Console.ReadLine());
        //Creating an integer variable sum with 0 intial value
        int sum=0;
        //Using a for loop for checking that number is divisible by i or not 
        for(int i=1; i<number; i++){
            if(number%i==0){
                //adding value of i to the sum variable for comparison between sum and number
                sum+=i;
            }
        }
        if(sum>number){
            //Printing the Abundant Number to the output
            Console.WriteLine("Abundant Number");
        }
        else{
            //Printing the Not an Abundant Number to the output
            Console.WriteLine("Not an Abundant Number");
        }
    }
}