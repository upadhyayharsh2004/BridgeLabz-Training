using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Book
{
    // static: shared among all books
    public static string LibraryName;

    // instance variables
    string Title;
    string Author;

    // readonly: unique book identifier
    public readonly string ISBN;

    // constructor using 'this'
    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    // static method
    public static void DisplayLibraryName()
    {
        Console.WriteLine("\nLibrary Name: " + LibraryName);
    }

    // instance method
    public void DisplayBookDetails()
    {
        Console.WriteLine("\n--- BOOK DETAILS ---");
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN  : " + ISBN);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Library Name: ");
        Book.LibraryName = Console.ReadLine();

        Console.Write("Enter number of books: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("\nEnter details for Book " + i);

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();

            Book book = new Book(title, author, isbn);

            // is operator validation
            if (book is Book)
            {
                Book.DisplayLibraryName();
                book.DisplayBookDetails();
            }
        }
    }
}
