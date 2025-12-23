using System;
class NumberToOneRewrite{
    public static void Main(string[]args){
        //taking user inputted value for the countdown as a counter variable
        int counter=Convert.ToInt32(Console.ReadLine());
        //Using for loop for a taking user inputted number to 1
        for(int i=counter; i>=1; i--){
            Console.WriteLine(counter);//printing the counter from user inputted number to 1
        }
    }
}


