using System;
class SumOfNumbersToZero{
    public static void Main(string[]args){
        //creating inputted value for the variable total of double data type
        double total=0.0;
        //creating and taking user inputted value for the variable of double data type
        double userInputtedValue=Convert.ToDouble(Console.ReadLine());
        //Using while loop to check user inputted number is 0
        while(userInputtedValue!=0){
            total+=userInputtedValue;//adding value of userInputtedValue variable to total
            userInputtedValue=Convert.ToDouble(Console.ReadLine());//taking user input again till the user
            // give input 0
        }
        Console.WriteLine(total);//printing the total sum of variable total 
    }
}
