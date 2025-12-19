using System;
class SquarePerimeter{
    public static void Main(string[] args){
        double perimeter;
        perimeter = Convert.ToDouble(Console.ReadLine());
        double lengthSide=perimeter/4;
        Console.WriteLine(
            "The length of the side is"+" "+lengthSide+
            " "+"whose perimeter is"+" "+perimeter);
    }
}
