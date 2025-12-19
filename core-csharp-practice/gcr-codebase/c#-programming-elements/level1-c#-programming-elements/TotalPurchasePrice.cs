using System;
class TotalPurchasePrice{
    public static void Main(string[] args){
        double unitPrice;
        unitPrice = Convert.ToDouble(Console.ReadLine());
        int quantity=Convert.ToInt32(Console.ReadLine());
        double totalPrice=quantity*unitPrice;
        Console.WriteLine("The total price is INR"+" "+totalPrice+" "+"if the quantity"+" "+quantity+" "+"and unit price is INR"+" "+totalPrice);
    }
}