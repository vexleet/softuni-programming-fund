using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<int>>> dragons 
                = new Dictionary<string, SortedDictionary<string, List<int>>>();

            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                string currentDragon = Console.ReadLine();
                string[] currentDragonToArray = currentDragon.Split(' ');
                string typeOfDragon = currentDragonToArray[0];
                string nameOfDragon = currentDragonToArray[1];
                List<int> statsOfDragon = GetStatsOfDragon(currentDragonToArray.ToList());

                if (!dragons.ContainsKey(typeOfDragon))
                {
                    dragons.Add(typeOfDragon, new SortedDictionary<string, List<int>>());
                }
                if(dragons.ContainsKey(typeOfDragon) && dragons[typeOfDragon].ContainsKey(nameOfDragon))
                {
                    dragons[typeOfDragon][nameOfDragon] = statsOfDragon;
                }
                else
                {
                    dragons[typeOfDragon].Add(nameOfDragon, statsOfDragon);
                }
            }

            foreach (var item in dragons)
            {
                var totalStats = item.Value.Select(x => x.Value).ToList();
                var totalDamageAverage = SumElements(totalStats, 0);
                var totalHealthAverage = SumElements(totalStats, 1);
                var totalArmorAverage = SumElements(totalStats, 2);

                Console.WriteLine($"{item.Key}::({totalDamageAverage:F2}/{totalHealthAverage:F2}/{totalArmorAverage:F2})");

                Console.Write($"-{string.Join("-", item.Value.Select(x => $"{x.Key} -> damage: {x.Value[0]}, health: {x.Value[1]}, armor: {x.Value[2]}\r\n"))}");
            }
        }

        static double SumElements(List<List<int>> elements, int index)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < elements.Count(); i++)
            {
                result.Add(elements[i][index]);
            }

            return result.Average();
        }

        static List<int> GetStatsOfDragon(List<string> stats)
        {
            List<int> result = new List<int>();
            var damage = stats[2];
            var health = stats[3];
            var armor = stats[4];

            for (int i = 2; i < stats.Count(); i++)
            {
                if(stats[i] == "null" && i == 2)
                {
                    damage = "45";
                }
                else if(stats[i] == "null" && i == 3)
                {
                    health = "250";
                }
                else if(stats[i] == "null" && i == 4)
                {
                    armor = "10";
                }
            }

            result.Add(int.Parse(damage));
            result.Add(int.Parse(health));
            result.Add(int.Parse(armor));

            return result;
        }
    }
}
