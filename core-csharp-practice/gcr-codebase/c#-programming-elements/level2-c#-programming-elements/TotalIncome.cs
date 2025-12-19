using System;
class TotalIncome{
    public static void Main(string[] args){
        double salary;
        double bonus;
        salary=Convert.ToDouble(Console.ReadLine());
        bonus=Convert.ToDouble(Console.ReadLine());
        double totalIncome = salary + bonus;
        Console.WriteLine(
            "The salary is INR"+" "+"salary and bonus is INR"+" "+bonus+" "+"."+" "+"Hence Total Income is INR"+" "+totalIncome);
    }
}
