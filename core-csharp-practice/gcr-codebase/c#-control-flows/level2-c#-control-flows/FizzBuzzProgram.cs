using System;
class FizzBuzzProgram{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        //checking the number is positive or not 
        if (n <= 0){
            Console.WriteLine("Please enter positive integer");
            return;
        }
        // Loop from 0 to n for checking all different condition based on given question
        for (int i=0;i<=n;i++){
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
        }
    }
}