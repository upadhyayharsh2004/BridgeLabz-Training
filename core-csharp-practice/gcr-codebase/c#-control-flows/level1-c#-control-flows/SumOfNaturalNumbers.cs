using System;
class sumOfNaturalNumbers{
    public static void Main(string[]args){
        //creating and taking user inputted value for the sum of N Natural Numbers
        int userInputtedValue=Convert.ToInt32(Console.ReadLine());
        int i=0; //Iniatlizing the integer i for iteration till natural numbers
        int sumOfNaturalNumbers=0;//and integer sum variable for sum of numbers from 0 to natural numbers given by user
        //Using while loop for checking that the number is natural or not and sum of natural numbers from 0 to inputted value 
        while(i<=userInputtedValue && userInputtedValue>=0){
            sumOfNaturalNumbers+=i;//adding value of i to the sumOfNaturalNumbers variable 
            i++;//increasing the value of i from 0 to till the value given by the user 
        }
        int sumOfNaturalNumbersByFormula=(userInputtedValue*(userInputtedValue+1))/2;//calculating sum Of N Natural Numbers using formula
        if(sumOfNaturalNumbers==sumOfNaturalNumbersByFormula){
            Console.WriteLine("Both the values" +" "+sumOfNaturalNumbersByFormula+" "+sumOfNaturalNumbers+" "+"coming from using while loop and using formula"+" "+"are same");
        }
        Console.WriteLine(sumOfNaturalNumbers);//printing the total sum of variable sumOfNaturalNumbers
    }
}
