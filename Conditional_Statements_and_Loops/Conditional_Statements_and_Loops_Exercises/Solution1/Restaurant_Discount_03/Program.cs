using System;

namespace Restaurant_Discount_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double discount = 0;
            int packagePrice = 0;
            int hallPrice = 0;
            int totalPrice = 0;
            double totalPriceWithDiscount = 0;
            double pricePerPerson = 0;

            if(groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if(package == "Normal")
            {
                discount = 0.05;
                packagePrice = 500;
            }
            else if(package == "Gold")
            {
                discount = 0.1;
                packagePrice = 750;
            }
            else if(package == "Platinum")
            {
                discount = 0.15;
                packagePrice = 1000;
            }

            if(groupSize <= 50)
            {
                hallPrice = 2500;
                totalPrice = hallPrice + packagePrice;
                totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                pricePerPerson = totalPriceWithDiscount / groupSize;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if(groupSize>50 && groupSize <= 100)
            {
                hallPrice = 5000;
                totalPrice = hallPrice + packagePrice;
                totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                pricePerPerson = totalPriceWithDiscount / groupSize;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if(groupSize > 100)
            {
                hallPrice = 7500;
                totalPrice = hallPrice + packagePrice;
                totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                pricePerPerson = totalPriceWithDiscount / groupSize;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }

        }
    }
}
