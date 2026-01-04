using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_and_object.level_1
{
    internal class Book
    {

        string title;

        string author;

        double price;

        public static void Main(string[] args)
        {
            Book book = new Book();
            Console.Write("ENTER BOOK TITLE: ");
            book.title = Console.ReadLine();
            Console.Write("ENTER AUTHOR NAME: ");
            book.author = Console.ReadLine();
            Console.Write("ENTER BOOK PRICE: ");
            book.price = Convert.ToDouble(Console.ReadLine());
            book.DisplayDetails();

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Book Title: " + title);

            Console.WriteLine("Author Name: " + author);

            Console.WriteLine("Book Price: " + price);
        }
    }
}