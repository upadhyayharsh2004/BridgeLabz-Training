using System;
class TriangleArea{
    public static void Main(string[] args){
        double baseInches, heightInches;
        baseInches = Convert.ToDouble(Console.ReadLine());
        heightInches = Convert.ToDouble(Console.ReadLine());
        double areaInSqInches = 0.5 * baseInches * heightInches;
        double areaInSqCm = areaInSqInches * 6.4516;
        Console.WriteLine(
            "The area of the triangle is"+" "+areaInSqInches+" "+"square inches"+
            " "+"and"+" "+areaInSqCm+" "+"square centimeters");
    }
}
