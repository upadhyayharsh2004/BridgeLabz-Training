using System;
class GreatestFactorOfANumber{
    public static void Main(string[] args){
        //Read the number entered by the user and Get an integer input and assign it to the number variable. 
        int number = Convert.ToInt32(Console.ReadLine());
        //As well as defining a greatestFactor variable and assign it to 1
        int greatestFactor=1;
        //Create a for loop that runs from last but one till 1 as in i = number - 1 to i = 1.
        for(int i=number-1;i>=1;i--){
            //checking if the number is perfectly divisible by i
            if(number%i==0){
                //assigning i to greatestFactor variable
                greatestFactor=i;
                //using break statement if we got our 1 greatestFactor data then we will break
                break;
            }
        }
        //Displaying the greatestFactor variable outside the loop
        Console.WriteLine(greatestFactor);
    }
}