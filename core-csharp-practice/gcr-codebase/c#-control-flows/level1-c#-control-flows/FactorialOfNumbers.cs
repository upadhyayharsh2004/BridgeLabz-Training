using System;
class FactorialOfNumbers{
    public static void Main(string[]args){
        //creating and taking user inputted value for the factorial of numbers
        int userInputtedValue=Convert.ToInt32(Console.ReadLine());
        //Iniatlizing the integer i for iteration till the factorial of that numbers
        int i=1;
        //integer data type for factorial of numbers variable for factorial of numbers from 1 to numbers given by user
        int factorialOfNumbers=1;
        //Using while loop for checking that the number is positive or not and factorial of natural numbers from 1 to inputted value by user
        while(i<=userInputtedValue && userInputtedValue>=0){
            factorialOfNumbers*=i;//multiplication of value of i to the factorialOfNumbers variable 
            i++;//increasing the value of i from 1 to till the value given by the user 
        }
        Console.WriteLine(factorialOfNumbers);//printing the factorial of number given by user 
    }
}