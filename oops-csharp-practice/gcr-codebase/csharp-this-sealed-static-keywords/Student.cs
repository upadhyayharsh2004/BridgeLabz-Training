using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.scenario_based
{
    internal class Student
    {
        //attributes
        static string UniversityName = "XYZ UNIVERSITY";

        string Name;

        readonly int RollNumber;

        static int totalStudents = 0;

        string Grade;


        public Student(string Name, int RollNumber, string Grade)
        {
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;
            totalStudents++;

        }
        public static int DisplayTotalStudents()
        {
            return totalStudents;
        }


        public static void Main(string[] args)
        {
            TakeInputs();
        }

        public static void TakeInputs()
        {

            Console.WriteLine("\n--- STUDENT DETAILS ---");

            Console.WriteLine("ENTER STUDENT NAME");

            string Name = Console.ReadLine();

            Console.WriteLine("ENTER STUDENT ROLL NUMBER");

            int RollNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER STUDENT GRADE");

            string Grade = Console.ReadLine();

            Student student = new Student(Name, RollNumber, Grade);

            if (student is Student)
            {

                student.DisplayDetails();

                Console.WriteLine("Total Students: " + DisplayTotalStudents());

            }
        }

        public void DisplayDetails()
        {

            Console.WriteLine("STUDENT NAME: " + Name);

            Console.WriteLine("STUDENT ROLL NUMBER: " + RollNumber);

            Console.WriteLine("STUDENT GRADE: " + Grade);
        }
    }
}
