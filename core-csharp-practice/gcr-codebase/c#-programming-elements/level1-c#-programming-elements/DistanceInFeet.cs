using System;
class DistanceInFeet{
    public static void Main(string[] args){
        double distanceInFeet;
        distanceInFeet = Convert.ToDouble(Console.ReadLine());
        double distanceInYards=distanceInFeet/3;
        double distanceInMiles=distanceInYards/1760;
        Console.WriteLine(
            "The distance is"+" "+distanceInFeet+" "+"feet"+
            " "+"which is"+" "+distanceInYards+" "+"yards"+" "+"and"+" "+distanceInMiles+" "+"miles");
    }
}
