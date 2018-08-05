using System;

namespace Choose_a_Drink_2._0_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (person == "Athlete")
            {
                double price = quantity * 0.70;
                Console.WriteLine($"The {person} has to pay {price:F2}.");
            }
            else if (person == "Businessman" || person == "Businesswoman")
            {
                double price = quantity * 1;
                Console.WriteLine($"The {person} has to pay {price:F2}.");
            }
            else if (person == "SoftUni Student")
            {
                double price = quantity * 1.70;
                Console.WriteLine($"The {person} has to pay {price:F2}.");
            }
            else
            {
                double price = quantity * 1.20;
                Console.WriteLine($"The {person} has to pay {price:F2}.");
            }
        }
    }
}
