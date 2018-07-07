using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary__05
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> prices = new Dictionary<string, double>();

            int booksAndAuthors = int.Parse(Console.ReadLine());

            for (int i = 0; i < booksAndAuthors; i++)
            {
                string[] currentBook = Console.ReadLine().Split().ToArray();

                string currentAuthor = currentBook[1];
                double currentPrice = double.Parse(currentBook[currentBook.Length - 1]);

                if (!prices.ContainsKey(currentAuthor))
                {
                    prices.Add(currentAuthor, 0);
                }
                prices[currentAuthor] += currentPrice;
            }

            var list = prices.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
