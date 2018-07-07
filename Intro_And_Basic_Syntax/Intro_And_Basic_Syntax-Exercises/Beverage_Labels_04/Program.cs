using System;

namespace Beverage_Labels_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            int energyPer100ml = int.Parse(Console.ReadLine());
            int sugarPer100ml = int.Parse(Console.ReadLine());

            double volumePer100ml = volume / 100;
            //Console.WriteLine(volumePer100ml);
            double energy = energyPer100ml * volumePer100ml;
            double sugar = sugarPer100ml * volumePer100ml;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
