using System;
class ChocolateDistribution{
    public static void Main(string[]args){
        int numberOfChocolates=Convert.ToInt32(Console.ReadLine());
        int numberOfChildren=Convert.ToInt32(Console.ReadLine());
        double remainingChocolates=numberOfChocolates%numberOfChildren;
        double eachChildChocolates= numberOfChocolates/numberOfChildren;
        Console.WriteLine("The number of chocolates each child gets is"+" "+eachChildChocolates+" "+"and the number of remaining chocolates is"+" "+remainingChocolates);
    }
}