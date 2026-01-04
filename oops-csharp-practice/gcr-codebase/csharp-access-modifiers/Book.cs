using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_access_modifiers
{
    internal class Book
    {
        public string isbn;
        protected string title;
        private string author;
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public string getAuthor()
        {
            return this.author;
        }
    }
    internal class Ebook : Book
    {
        public static void Main(string[] args)
        { 
            TakeInput();
        }

        public static void TakeInput()
        {
            //create object
            Ebook ebook = new Ebook();

            //take isbn input
            Console.WriteLine("ENTER ISBN: ");
            ebook.isbn = Console.ReadLine();

            //take title input
            Console.WriteLine("ENTER TITLE: ");
            ebook.title = Console.ReadLine();

            //take author input
            Console.WriteLine("ENTER AUTHOR: ");
            ebook.setAuthor(Console.ReadLine());

            ebook.DisplayDetails();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("ISBN: " + isbn);

            Console.WriteLine("TITLE: " + title);

            Console.WriteLine("AUTHOR: " + getAuthor());
        }
    }
}