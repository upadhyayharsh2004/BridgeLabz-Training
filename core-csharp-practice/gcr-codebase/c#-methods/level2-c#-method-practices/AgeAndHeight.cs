using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class AgeAndHeight
    {
        public static void Main(string[] args)
        {
            int[] ageOfFriends = new int[3];
            int[] heightOfFriends = new int[3];
            for (int i = 0; i < ageOfFriends.Length; i++)
            {
                ageOfFriends[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ageOfFriends.Length; i++)
            {
                heightOfFriends[i] = Convert.ToInt32(Console.ReadLine());
            }
            AgeAndHeight check = new AgeAndHeight();
            int ageChecked = check.ageToCheck(ageOfFriends);
            int heightChecked = check.heightToCheck(heightOfFriends);
            Console.WriteLine("The Youngest Age of friends Out of 3 with the age of is" + " " + ageChecked);
            Console.WriteLine("The Tallest Height of friends Out of 3 with the Height of is" + " " + heightChecked);
        }
        public int ageToCheck(int[] ageOfFriends)
        {
            if (ageOfFriends[0] <= ageOfFriends[1] && ageOfFriends[0] <= ageOfFriends[2])
            {
                return ageOfFriends[0];
            }
            else if (ageOfFriends[0] >= ageOfFriends[1] && ageOfFriends[1] <= ageOfFriends[2])
            {
                return ageOfFriends[1];
            }
            else if (ageOfFriends[2] <= ageOfFriends[1] && ageOfFriends[0] >= ageOfFriends[2])
            {
                return ageOfFriends[2];
            }
            else
            {
                return 0;
            }
        }
        public int heightToCheck(int[] heightOfFriends)
        {
            if (heightOfFriends[0] >= heightOfFriends[1] && heightOfFriends[0] >= heightOfFriends[2])
            {
                return heightOfFriends[0];
            }
            else if (heightOfFriends[0] <= heightOfFriends[1] && heightOfFriends[1] >= heightOfFriends[2])
            {
                return heightOfFriends[1];
            }
            else if (heightOfFriends[2] >= heightOfFriends[1] && heightOfFriends[0] <= heightOfFriends[2])
            {
                return heightOfFriends[2];
            }
            else
            {
                return 0;
            }
        }
    }
}
