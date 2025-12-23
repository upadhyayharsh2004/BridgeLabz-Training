using System;
class SumOfNumbersToZeroOrNegative{
    public static void Main(string[]args){
        //creating inputted value for the variable total of double data type
        double total=0.0;
        //creating and taking user inputted value for the variable of double data type
        double userInputtedValue=Convert.ToDouble(Console.ReadLine());
        //Using while loop for infinite iteration of the code 
        while(true){
            if(userInputtedValue!=0 && userInputtedValue>0){//checking that user inputed value should not be 0 or negative
                total+=userInputtedValue;//adding value of userInputtedValue variable to total
                userInputtedValue=Convert.ToDouble(Console.ReadLine());// //taking user input again till the user
                // give input 0
            }
            else if(userInputtedValue==0 || userInputtedValue<0){//checking that the user inputted is  0 or negative or not 
                break;//breaking the while loop if there is 0 or negative value entered by user
            }
        }
        Console.WriteLine(total);//printing the total sum of variable total 
    }
}
