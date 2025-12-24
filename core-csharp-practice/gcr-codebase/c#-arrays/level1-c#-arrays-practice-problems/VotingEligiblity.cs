using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays
{
   internal class VotingEligiblity
   {
       public static void Main(string[] args)
       {
           //Declaring an array with the size of 10 to store student ages
           int[] studentAge = new int[10];
           for (int i = 0; i < studentAge.Length; i++)
           {
               //and taking user input for the student's age 
               studentAge[i] = Convert.ToInt32(Console.ReadLine());
           }
           //Looping through the array using the length property 
           for (int i = 0; i < studentAge.Length; i++)
           {
               //using if else condition to check the age eligibility for voting
               if (studentAge[i] < 0)
               {
                   //printing invalid age message
                   Console.WriteLine("invalid age");
               }
               else if (studentAge[i] >= 18)
               {
                   //printing that the student with age is eligible to vote or not 
                   Console.WriteLine("The student with the age" + " " + studentAge[i] + " " + "can vote.");
               }
               else
               {
                   Console.WriteLine("The student with the age" + " " + studentAge[i] + " " + "cannot vote.");
               }
           }
       }
   }
}