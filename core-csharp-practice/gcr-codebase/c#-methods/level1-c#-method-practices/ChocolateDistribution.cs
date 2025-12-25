using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class ChocolateDistribution
   {
       public static void Main(string[] args)
       {
           //Getting an integer value input from the user for the numberOfchocolates and numberOfChildren
           int numberOfchocolates = Convert.ToInt32(Console.ReadLine());
           int numberOfChildren = Convert.ToInt32(Console.ReadLine());
           //Calling a method to find each chocolate disturbted and remaining chocolate and storing it in array to print further
           int[] checkedArray = FindChocolateDistributedAndRemainedChocolates(numberOfchocolates, numberOfChildren);
           Console.WriteLine("The Chocolate Distributed and Remained Chocolate is" + " " +checkedArray[0] + " " + "and" + " " + checkedArray[1]);
       }
       public static int[] FindChocolateDistributedAndRemainedChocolates(int numberOfchocolates, int numberOfChildren)
       {
           int[] array = new int[2];
           int chocolatesDistributed = numberOfchocolates/ numberOfChildren;
           int remainedChocolates = numberOfchocolates % numberOfChildren;
           array[0] =chocolatesDistributed;
           array[1] = remainedChocolates;
           return array;
       }
   }
}
