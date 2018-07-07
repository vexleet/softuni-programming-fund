using System;

namespace SweetDesert_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            int portions = (int)Math.Ceiling((double)numberOfGuests / 6);
            decimal neededProductPrice = (portions * (2 * priceOfBananas)) + (portions * (4 * priceOfEggs)) + (portions * (0.2m * priceOfBerries));

            if(amountOfCash >= neededProductPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededProductPrice:f2}lv.");
            }
            else
            {
                var neededMoney = neededProductPrice - amountOfCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }
    }
}
