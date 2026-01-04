using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Book Containing book details
    internal class Book
    {
        //protected variables 
        protected string title;

        protected int publicationYear;

        //parameterized constructor for Book class
        public Book(string title, int publicationYear)
        {
            this.title = title;
            this.publicationYear = publicationYear;
        }

        //method to display book info in our program
        public virtual void DisplayInfo()
        {
            Console.WriteLine("TITLE: " + title);
            Console.WriteLine("YEAR OF PUBLICATION: " + publicationYear);
        }

    }

    //derived class Author deriving property
    class Author : Book
    {
        //private variables
        string name;

        string bio;

        //parameterized constructor
        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
        {
            this.name = name;
            this.bio = bio;
        }

        //override DisplayInfo method  to include author details
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine("AUTHOR: " + name);

            Console.WriteLine("BIO: " + bio);
        }
    }

    //class containing Main method
    class BookDetails
    {
        public static void Main(string[] args)
        {
            //call the TakeInputs method for inputs
            TakeInputs();
        }

        //method to take user inputs in program
        public static void TakeInputs()
        {
            //take book title input using Console
            Console.Write("ENTER BOOK TITLE: ");
            string title = Console.ReadLine();

            //take year input using Console
            Console.Write("ENTER PUBLICATION YEAR: ");
            int year = Convert.ToInt32(Console.ReadLine());

            //take author name input using Console
            Console.Write("ENTER AUTHOR NAME: ");
            string name = Console.ReadLine();

            //take bio input using Console
            Console.Write("ENTER BIO: ");
            string bio = Console.ReadLine();

            //create object of Author class and pass the inputs to constructor
            Book book = new Author(title, year, name, bio);

            //call DisplayInfo method to display book details in our program
            Console.WriteLine("\nBOOK DETAILS: ");

            book.DisplayInfo();

        }
    }
}