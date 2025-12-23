using System;
class FizzBuzzWhile{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        //Initializing the i variable with the value 0 in it for using while loop
        int i=0;
        //checking the number is positive or not 
        if (n<0){
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        // Loop from 0 to n for checking all different condition based on given question
        while(i<=n){
            if (i%3==0&&i%5==0){
                Console.WriteLine("FizzBuzz");
            }
            else if(i%3==0){
                Console.WriteLine("Fizz");
            }
            else if(i%5==0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
            i++;
        }
    }
}