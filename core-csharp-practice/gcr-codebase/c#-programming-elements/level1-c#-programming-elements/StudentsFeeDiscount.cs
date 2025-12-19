using System;
class StudentsFeeDiscount{
    public static void Main(string[] args){
        double fee = Convert.ToDouble(Console.ReadLine());
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;
        Console.WriteLine(
            "The discount amount is INR"+" "+discount+" "+"and final discounted fee is INR"+" "+finalFee);
    }
}
