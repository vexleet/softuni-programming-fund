using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibraryWithClasses_05
{
    class Book
    {
        public string Title;
        public string Author;
        public string Publisher;
        public DateTime RealeaseDate;
        public string ISBN;
        public double Price;
    }

    class Library
    {
        public string Name;
        public List<Book> Books;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library();
            List<Book> books = new List<Book>();

            for (int i = 0; i < numOfBooks; i++)
            {
                Book book = new Book();
                string[] currentBook = Console.ReadLine().Split().ToArray();
                book.Title = currentBook[0];
                book.Author = currentBook[1];
                book.Publisher = currentBook[2];
                book.RealeaseDate = DateTime.ParseExact(currentBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = currentBook[4];
                book.Price = double.Parse(currentBook[5]);

                books.Add(book);
            }
            library.Books = books;

            var ordered = library.Books.GroupBy(x => x.Author)
                                        .Select(g => new
                                        {
                                            Author = g.Key,
                                            Prices = g.Sum(s => s.Price)
                                        })
                                        .OrderByDescending(x => x.Prices)
                                        .ThenBy(x => x.Author)
                                        .ToList();
            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Author} -> {item.Prices:f2}");
            }

        }
    }
}
