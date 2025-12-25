using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level1_c__methods_practices
{
    internal class PossibleHandShakes
    {
        public static void Main(string[] args)
        {
            int numberOfStudents=Convert.ToInt32(Console.ReadLine());
            double combinationOfPossibleHandShakes=(numberOfStudents*(numberOfStudents-1))/2;
            Console.WriteLine("The Number of Possible Handshakes is"+" "+combinationOfPossibleHandShakes);
        }
    }
}
