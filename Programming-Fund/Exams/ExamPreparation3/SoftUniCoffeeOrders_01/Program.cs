using System;
using System.Globalization;

namespace SoftUniCoffeeOrders_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = int.Parse(Console.ReadLine());

                decimal price = (System.DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsules) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                sum += price;
            }


            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}

static string[] reverseNumbers(string[] list, long start, long count)
{
    List<string> getNumbers = new List<string>();
    long startSave = start;

    for (long i = 0; i < count; i++)
    {
        getNumbers.Add(list[(int)start]);
        start++;
    }

    getNumbers.Reverse();

    for (long i = 0; i < count; i++)
    {
        list[(int)startSave] = getNumbers[(int)i];
        startSave++;
    }
    return list;
}