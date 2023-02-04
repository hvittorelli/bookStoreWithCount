using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;
        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        public void SetTrans() 
        {
            _transactions++;
        }
        public int GetId()
        {
            return _Id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();
            book1.SetTrans();
            book1.SetId(20);
            book1.SetTitle("The Untethered Soul");
            book1.SetAuthor("Michael Signer");

            Book book2 = new Book();
            book2.SetTrans();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title of the book: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author of the book: ");
            book2.SetAuthor(Console.ReadLine());

            Book book3 = new Book(40, "The Cat in the Hat", "Dr. Seuss");
            book3.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title of the book:  ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author of the book:  ");
            string tempAuthor = Console.ReadLine();
            Book book4 = new Book(tempID, tempTitle, tempAuthor);
            book4.SetTrans();

            Console.WriteLine($"The book inventory has {book1.GetTrans()} new books.");
            displayMembers(book1);
            displayMembers(book2);
            displayMembers(book3);
            displayMembers(book4);
        }

        static void displayMembers(Book book)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
        }
    }
}