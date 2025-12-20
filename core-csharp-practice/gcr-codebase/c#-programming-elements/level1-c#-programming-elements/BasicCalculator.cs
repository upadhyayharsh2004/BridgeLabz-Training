using System;
class BasicCalculator{
    public static void Main(string[]args){
        float number1=Convert.ToSingle(Console.ReadLine());
        float number2=Convert.ToSingle(Console.ReadLine());
        float additionOfNumbers=number1+number2;
        float subtractionOfNumbers=number1-number2;
        float divisonOfNumbers=number1/number2;
        float multiplicationOfNumbers=number1*number2;
        Console.WriteLine("The addition,subtraction,multiplication and divison of 2 numbers"+" "+number1+" "+"and"+" "+number2
            +" "+"is"+" "+additionOfNumbers+","+" "+subtractionOfNumbers+","+" "+divisonOfNumbers+" ,and"+" "+multiplicationOfNumbers);
    }
}