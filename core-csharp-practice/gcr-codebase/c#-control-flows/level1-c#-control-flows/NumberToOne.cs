using System;
class NumberToOne{
    public static void Main(string[]args){
        //taking user inputted value for the countdown as a counter variable
        int counter=Convert.ToInt32(Console.ReadLine());
        //Using while loop for a taking user inputted number to 1
        while(counter>=1){
            Console.WriteLine(counter);//// decrement the counter
            counter--;
        }
    }
}


