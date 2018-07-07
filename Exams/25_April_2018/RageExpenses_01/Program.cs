using System;

namespace RageExpenses_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int trashedHeadsets = lostGames / 2;
            int trashedMouse = lostGames / 3;         
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = trashedKeyboard / 2;
            //if (trashedDisplay != 0)
            //{
            //   trashedDisplay = lostGames / Math.Floor((trashedKeyboard / 2));
            //}

            var result = (headsetPrice * trashedHeadsets) + (mousePrice * trashedMouse) + (keyboardPrice * trashedKeyboard) + (trashedDisplay * displayPrice);
            Console.WriteLine($"Rage expenses: {result:f2} lv.");
        }
    }
}
