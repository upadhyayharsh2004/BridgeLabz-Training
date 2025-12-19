using System;
class SimpleInterestCalculator{
    public static void Main(string[] args){
        double principal=Convert.ToDouble(Console.ReadLine());
        double rate=Convert.ToDouble(Console.ReadLine());
        float time=Convert.ToSingle(Console.ReadLine());
        double simpleInterest=(principal*rate*time)/100;
        Console.WriteLine(
            "The Simple Interst is"+" "+simpleInterest+" "+"for principal"+" "+principal+" "+
            ","+ "Rate of Interest"+" "+rate+" "+"and Time"+" "+time);
    }
}
