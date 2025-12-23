using System;
class CountNumberOfDigits{
    public static void Main(string[] args){
        // Read the number entered by the user
        int number = Convert.ToInt32(Console.ReadLine());
        //Creating an integer variable count with 0 value
        int count=0;
        //Using if loop to check if the entered / inputted number is 0 then the count will be 1
        if(number==0){
            Console.WriteLine(1);
        }
        //Using a loop to iterate until number is not equal to 0.
        while(number!=0){
            //Removing the last digit from number in each iteration
            number=number/10;
            //Increasing the count by 1 to count number of digits present in number
            count++;
        }
        //printing the number of digits that are present in that number
        Console.WriteLine(count);
    }
}