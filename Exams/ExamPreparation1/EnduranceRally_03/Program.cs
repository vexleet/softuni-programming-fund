using System;
using System.Linq;

namespace EnduranceRally_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(' ').ToArray();
            double[] trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] checkpoints = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                double fuel = drivers[i][0];

                for (int j = 0; j < trackLayout.Length; j++)
                {
                    if (!checkpoints.Contains(j))
                    {
                        fuel -= trackLayout[j];
                    }
                    else
                    {
                        fuel += trackLayout[j];
                    }

                    if(fuel <= 0)
                    {
                        Console.WriteLine($"{drivers[i]} - reached {j}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
