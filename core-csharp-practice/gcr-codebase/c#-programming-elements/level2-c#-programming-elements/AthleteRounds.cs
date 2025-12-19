using System;
class AthleteRounds{
    public static void Main(string[] args){
        double side1;
        double side2;
        double side3;
        side1=Convert.ToDouble(Console.ReadLine());
        side2=Convert.ToDouble(Console.ReadLine());
        side3=Convert.ToDouble(Console.ReadLine());
        double perimeter=side1 + side2 + side3;
        double distance=5000;
        double rounds=distance/perimeter;
        Console.WriteLine(
            "The total number of rounds the athlete will run is"+" "+rounds+" "+" to complete 5 km"
        );
    }
}
