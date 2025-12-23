using System;
class FactorsOfANumber{
    public static void Main(string[] args){
        // Read the number entered by the user and getting input value for a variable named number
        int number = Convert.ToInt32(Console.ReadLine());
        //Running a for loop from i = 1 to i = number where number is taken input by user
        for(int i=1;i<number;i++){
            //Checking in each iteration of the loop,if the number is perfectly divisible by i.
            if(number%i==0){
                //Printing the value of data of i to the output screen if number is divisible by i then only 
                Console.WriteLine(i);
            }
        }
    }
}