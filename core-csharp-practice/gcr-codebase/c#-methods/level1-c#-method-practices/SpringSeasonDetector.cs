using System;

namespace BridgeLabzTraining.level1_c__methods_practices
{
   internal class SpringSeasonDetector
   {
       public static void Main(string[] args)
       {
           // Taking input for month from the command line
           int month=Convert.ToInt32(args[0]);
           // Taking input for day from the command line
           int day=Convert.ToInt32(args[1]);
           // Creating an object of the class to access the method
           SpringSeasonDetector season=new SpringSeasonDetector();
           // Calling the method to check whether it is Spring Season
           bool isSpring=season.CheckSpringSeason(month, day);
           // Printing the result based on the returned boolean value
           if (isSpring)
           {
               Console.WriteLine("Its a Spring Season");
           }
           else
           {
               Console.WriteLine("Not a Spring Season");
           }
       }
       // Write a Method to check for Spring season and return a boolean true or false
       public bool CheckSpringSeason(int month, int day)
       {
           // Spring Season is from March 20 to June 20
           if ((month==3&&day>=20) ||
               (month==4)||
               (month==5)||
               (month==6&&day<=20))
           {
               return true;
           }
           return false;
       }
   }
}
