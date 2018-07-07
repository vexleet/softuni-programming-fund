using System;

namespace Hotel_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            double discount = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if(nights > 7)
                {
                    discount = 0.95;
                    studioPrice *= discount;
                }

                if(month == "October" && nights > 7)
                {
                    studioPrice *= (nights - 1);
                }
                else
                {
                    studioPrice *= nights;
                }
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {(doublePrice * nights):F2} lv.");
                Console.WriteLine($"Suite: {(suitePrice * nights):F2} lv.");
            }

            else if(month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nights > 14)
                {
                    discount = 0.9;
                    doublePrice *= discount;
                }

                if(month == "September" && nights > 7)
                {
                    studioPrice *= (nights - 1);
                }
                else
                {
                    studioPrice *= nights;
                }
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {(doublePrice * nights):F2} lv.");
                Console.WriteLine($"Suite: {(suitePrice * nights):F2} lv.");
            }

            else if(month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nights > 14)
                {
                    discount = 0.85;
                    suitePrice *= discount;
                }

                Console.WriteLine($"Studio: {(studioPrice * nights):F2} lv.");
                Console.WriteLine($"Double: {(doublePrice * nights):F2} lv.");
                Console.WriteLine($"Suite: {(suitePrice * nights):F2} lv.");
            }
        }
    }
}
