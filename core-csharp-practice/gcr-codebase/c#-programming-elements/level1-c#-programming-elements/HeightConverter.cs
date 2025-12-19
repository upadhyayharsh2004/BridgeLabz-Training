using System;
class HeightConverter{
    public static void Main(string[] args){
        double heightCm;
        heightCm = Convert.ToDouble(Console.ReadLine());
        double totalInches = heightCm / 2.54;
        double feet = (totalInches / 12.0);
        double inches = totalInches % 12;
        Console.WriteLine(
            "Your Height in cm is"+" "+heightCm+" "+"while in feet is"+" "+feet+" "+"and inches is"+" "+inches);
    }
}
