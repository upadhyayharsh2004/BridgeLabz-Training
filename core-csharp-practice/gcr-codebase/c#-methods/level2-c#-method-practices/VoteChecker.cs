using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class StudentVoteChecker
    {
        public static void Main(string[] args)
        {
            int[] studentAges = new int[10];
            for (int i = 0; i < studentAges.Length; i++)
            {
                studentAges[i] = Convert.ToInt32(Console.ReadLine());
            }
            StudentVoteChecker check = new StudentVoteChecker();
            for (int i = 0; i < studentAges.Length; i++)
            {
                bool checkedVote = check.StudentVoteChecked(studentAges[i]);
                if (checkedVote)
                {
                    Console.WriteLine("The Student With Age" + " " + studentAges[i] + " " + "Can Vote");
                }
                else
                {
                    Console.WriteLine("The Student With Age" + " " + studentAges[i] + " " + "Cannot Vote");
                }
            }
        }
        public bool StudentVoteChecked(int voteToBeChecked)
        {
            if (voteToBeChecked < 0)
            {
                return false;
            }
            else if (voteToBeChecked >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
