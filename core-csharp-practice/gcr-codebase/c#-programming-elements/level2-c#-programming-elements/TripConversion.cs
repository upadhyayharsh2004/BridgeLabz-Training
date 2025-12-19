using System;
class TripConversion{
    public static void Main(string[] args){
        string name, fromCity, viaCity, toCity;
        double fromToVia, viaToFinalCity, timeTaken;
        name = Console.ReadLine();
        fromCity = Console.ReadLine();
        viaCity = Console.ReadLine();
        toCity = Console.ReadLine();
        fromToVia = Convert.ToDouble(Console.ReadLine());
        viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        timeTaken = Convert.ToDouble(Console.ReadLine());
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;
        Console.WriteLine("The results of the trip are:"+" "+totalDistance+" "+"miles,"+" " +timeTaken+" "+"hours,"+" "+" "+"and"+" "+averageSpeed+" "+"miles/hour");
    }
}
