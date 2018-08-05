using System;

namespace PadawanEquipment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoneyIvanHas = decimal.Parse(Console.ReadLine());
            decimal countOfStudents = decimal.Parse(Console.ReadLine());
            decimal priceOfLightSaber = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());

            decimal saberPrice = priceOfLightSaber * (countOfStudents + Math.Ceiling(countOfStudents * 0.1M));
            decimal robesPrice = priceOfRobes * countOfStudents;
            decimal beltsPrice = priceOfBelts * (countOfStudents - Math.Floor(countOfStudents / 6));

            var total = saberPrice + robesPrice + beltsPrice;

            if(total <= amountOfMoneyIvanHas)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                var moneyNeeded = total - amountOfMoneyIvanHas;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
