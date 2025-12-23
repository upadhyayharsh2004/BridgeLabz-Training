using System;
class SumOfNaturalNumbersUsingForLoop{
    public static void Main(string[]args){
        //creating and taking user inputted value for the sum of N Natural Numbers
        int userInputtedValue=Convert.ToInt32(Console.ReadLine());
        ////and integer sum variable for sum of numbers from 0 to natural numbers given by user
        int sumOfNaturalNumbers=0;
        //Using for loop for sum of natural numbers from 0 to inputted value given by user using increase of iteration
        for(int i=0; i<=userInputtedValue;i++){
            if(userInputtedValue>=0){
                sumOfNaturalNumbers+=i;////adding value of i to the sumOfNaturalNumbers variable 
            }
        }
        int sumOfNaturalNumbersByFormula=(userInputtedValue*(userInputtedValue+1))/2;//calculating sum Of N Natural Numbers using formula
        if(sumOfNaturalNumbers==sumOfNaturalNumbersByFormula){
            Console.WriteLine("Both the values" +" "+sumOfNaturalNumbersByFormula+" "+sumOfNaturalNumbers+" "+"coming from using while loop and using formula"+" "+"are same");
        }
        Console.WriteLine(sumOfNaturalNumbers);//printing the total sum of variable sumOfNaturalNumbers
    }
}
