using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string input = Console.ReadLine();
            int counter = 1;
            string currentResource = "";
            int quantity = 0;

            while (input != "stop")
            {
                if (counter % 2 == 1)
                {
                    currentResource = input;
                }
                else
                {
                    quantity = int.Parse(input);

                    if (resources.TryGetValue(currentResource, out int quantityOfKey))
                    {
                        int value = quantityOfKey + quantity;
                        resources[currentResource] = value;
                    }
                    else
                    {
                        resources.Add(currentResource, quantity);
                    }
                }
                counter++;
                input = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
