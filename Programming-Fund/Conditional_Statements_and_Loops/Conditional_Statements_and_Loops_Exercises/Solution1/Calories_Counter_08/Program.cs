using System;

namespace Calories_Counter_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalIngredients = int.Parse(Console.ReadLine());
            int total = 0;
            for(int i = 0; i<totalIngredients; i++)
            {
                string ingredient = Console.ReadLine();

                if(ingredient.ToLower() == "cheese")
                {
                    total += 500;
                }
                else if(ingredient.ToLower() == "tomato sauce")
                {
                    total += 150;
                }
                else if(ingredient.ToLower() == "salami")
                {
                    total += 600;
                }
                else if(ingredient.ToLower() == "pepper")
                {
                    total += 50;
                }
            }

            Console.WriteLine($"Total calories: {total}");
        }
    }
}
