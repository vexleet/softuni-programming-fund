using System;
using System.Collections.Generic;
using System.Linq;
namespace LegendaryFarming_09
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> keyMaterials = new SortedDictionary<string, int>()
            {
                {"shards", 0},
                {"fragments",  0},
                {"motes", 0}
            };
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();
            int shadowmourneCounter = 0;
            int valanyrCounter = 0;
            int dragonwrathCounter = 0;
            string obtainedItem = "";

            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
            while (true)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (material == "shards")
                    {
                        shadowmourneCounter += quantity;
                        if (shadowmourneCounter >= 250)
                        {
                            shadowmourneCounter -= 250;
                            obtainedItem = "Shadowmourne";
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        valanyrCounter += quantity;
                        if (valanyrCounter >= 250)
                        {
                            valanyrCounter -= 250;
                            obtainedItem = "Valanyr";
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        dragonwrathCounter += quantity;
                        if (dragonwrathCounter >= 250)
                        {
                            dragonwrathCounter -= 250;
                            obtainedItem = "Dragonwrath";
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                    }
                }

                if(obtainedItem != "")
                {
                    break;
                }

                input = Console.ReadLine().ToLower().Split(' ').ToArray();
            }
            keyMaterials["shards"] = shadowmourneCounter;
            keyMaterials["fragments"] = valanyrCounter;
            keyMaterials["motes"] = dragonwrathCounter;
            Console.WriteLine($"{obtainedItem} obtained!");

            foreach (var item in keyMaterials.OrderByDescending(key => key.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
