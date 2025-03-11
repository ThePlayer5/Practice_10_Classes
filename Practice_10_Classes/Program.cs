using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1984", "Джордж Оруэлл", 328);
            book.PrintInfo();

            Console.ReadKey();
        }
    }
    class Book
    {
        public string Title;
        public string Author;
        public int Pages;
        public Book(string title_book, string author_book, int pages_book)
        {
            Title = title_book;
            Author = author_book;
            Pages = pages_book;
        }
        public static void PrintInfo()
        {
            Console.WriteLine($"Книга: {title}, Автор: {author}, Страниц: {pages}");
            Console.WriteLine();
        }
    }
}
