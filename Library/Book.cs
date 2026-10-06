using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;

        public Book(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }




        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
