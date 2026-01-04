using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Course containing course details
    internal class Course
    {
        //protected variables
        protected string courseName;

        protected int duration;

        //parameterized constructor for Course class
        public Course(string courseName, int duration)
        {
            this.courseName = courseName;
            this.duration = duration;
        }

        //method to display course info  for our program
        public virtual void DisplayInfo()
        {
            Console.WriteLine("COURSE NAME: " + courseName);
            Console.WriteLine("COURSE DURATION: " + duration);
        }
    }

    //derived class OnlineCourse deriving properties
    class OnlineCourse : Course
    {
        //protected variables for derived class
        protected string platform;

        protected bool isRecorded;

        //parameterized constructor for derived class
        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
        {
            this.platform = platform;
            this.isRecorded = isRecorded;
        }

        //override DisplayInfo method to include online course details
        public override void DisplayInfo()
        {
            //call base class DisplayInfo method for course details
            base.DisplayInfo();

            Console.WriteLine("PLATFORM :" + platform);

            Console.WriteLine("RECORDED: " + isRecorded);
        }
    }

    //derived class PaidOnlineCourse from OnlineCourse
    class PaidOnlineCourse : OnlineCourse
    {
        //private variables for PaidOnlineCourse class
        double fee;

        double discount;

        //parameterized constructor for PaidOnlineCourse class
        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
        {
            this.fee = fee;
            this.discount = discount;
        }

        //override DisplayInfo method for PaidOnlineCourse details
        public override void DisplayInfo()
        {
            //call base class DisplayInfo method for online course details
            base.DisplayInfo();

            Console.WriteLine("FEE: " + fee);

            Console.WriteLine("DISCOUNT: " + discount);

            double finalFee = fee - (fee * discount / 100);

            Console.WriteLine("FINAL FEE: " + finalFee);
        }
    }

    //class containing Main method for our program
    class CourseDetails
    {
        public static void Main(string[] args)
        {
            //call TakeInputs method for inputs
            TakeInputs();
        }

        //method to take user inputs in program
        public static void TakeInputs()
        {
            //take course name input for course details
            Console.Write("ENTER COURSE NAME: ");
            string name = Console.ReadLine();

            //take duration input for course details
            Console.Write("ENTER DURATION: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            //take platform input for course details
            Console.Write("ENTER PLATFORM: ");
            string platform = Console.ReadLine();

            //take course recorded input for course details
            Console.Write("IS COURSE RECORDED: ");
            bool isRecorded = Convert.ToBoolean(Console.ReadLine());

            //take course fee input for course details
            Console.Write("ENTER COURSE FEE: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            //take discount input for course details
            Console.Write("ENTER DISCOUNT: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            //create object of PaidOnlineCourse class
            Course course = new PaidOnlineCourse(name, duration, platform, isRecorded, fee, discount);

            //display course details using DisplayInfo method
            Console.WriteLine("\nCOURSE DETAILS: ");

            course.DisplayInfo();
        }
    }
}