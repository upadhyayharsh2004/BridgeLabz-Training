using System;
class WeightTokilogram{
    public static void Main(string[] args){
        double weightInPounds=Convert.ToDouble(Console.ReadLine());
        double weightInKilogram=weightInPounds/2.2;
        Console.WriteLine(
            "The weight of the person in pounds is"+" "+weightInPounds+" "+"and in kg is"+" "+weightInKilogram);
    }
}
