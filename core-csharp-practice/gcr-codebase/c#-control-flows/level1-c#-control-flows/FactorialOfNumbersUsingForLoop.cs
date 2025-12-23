using System;
class FactorialOfNumbersUsingForLoop{
    public static void Main(string[]args){
        //creating and taking user inputted value for the factorial of numbers
        int userInputtedValue=Convert.ToInt32(Console.ReadLine());
        //integer data type for factorial of numbers variable for factorial of numbers from 1 to numbers given by user
        int factorialOfNumbers=1;
        //Using for loop for factorial of natural numbers from 1 to inputted value by user
        for(int i=1; i<=userInputtedValue;i++){
            //checking that the user inputted value is natural number or not
            if(userInputtedValue>=0){
                //multiplication of value of i to the factorialOfNumbers variable
                factorialOfNumbers*=i;
            }
        }
        Console.WriteLine(factorialOfNumbers);//printing the factorial of number given by user 
    }
}