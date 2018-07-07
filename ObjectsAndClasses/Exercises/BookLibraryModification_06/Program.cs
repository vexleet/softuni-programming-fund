using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibraryModification_06
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
            var dict = new Dictionary<string, DateTime>();

            for (int i = 0; i < numOfBooks; i++)
            {
                Book book = new Book();
                string[] currentBook = Console.ReadLine().Split().ToArray();
                book.Title = currentBook[0];
                book.RealeaseDate = DateTime.ParseExact(currentBook[3], "dd.M.yyyy", CultureInfo.InvariantCulture);
                books.Add(book);
            }
            library.Books = books;

            var getDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in library.Books)
            {
                var tit = item.Title;
                var relD = item.RealeaseDate;
                if (!dict.ContainsKey(tit))
                {
                    dict.Add(tit, relD);
                }
                else
                {
                    dict[tit] = relD;
                }
            }

            foreach (var item in dict.OrderBy(x => x.Value).ThenBy(y => y.Key))
            {
                var result = DateTime.Compare(item.Value, getDate);
                if (result > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:d.MM.yyyy}");
                }
            }

        }
    }
}
