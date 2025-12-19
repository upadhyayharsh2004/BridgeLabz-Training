using System;
class PossibleHandShakes{
    public static void Main(string[]args){
        int numberOfStudents=Convert.ToInt32(Console.ReadLine());
        double combinationOfPossibleHandShakes=(numberOfStudents*(numberOfStudents-1))/2;
        Console.WriteLine("number of possible handshakes is"+" "+combinationOfPossibleHandShakes);
    }
}