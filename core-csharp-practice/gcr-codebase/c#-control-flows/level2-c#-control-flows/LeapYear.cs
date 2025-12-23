using System;
class LeapYear{
    public static void Main(){
        int year = int.Parse(Console.ReadLine());
        if (year < 1582){
            Console.WriteLine("Year must be 1582 or later");
        }
        else if (year % 400 == 0){
            Console.WriteLine("Year is a Leap Year");
        }
        else if (year % 100 == 0){
            Console.WriteLine("Year is Not a Leap Year");
        }
        else if (year % 4 == 0){
            Console.WriteLine("Year is a Leap Year");
        }
        else{
            Console.WriteLine("Year is Not a Leap Year");
        }
    }
}
