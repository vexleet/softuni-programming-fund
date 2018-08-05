using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ForceBook_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var padawans = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while(input != "Lumpawaroo")
            {
                string pattern1 = @"(.+?) (\|) (.+)";
                string pattern2 = @"(.+?) (\->) (.+)";
                Regex p1 = new Regex(pattern1);
                Regex p2 = new Regex(pattern2);

                if (p1.IsMatch(input))
                {
                    string[] inputArray = input.Split('|').ToArray();
                    string forceSide = inputArray[0].Substring(0, inputArray[0].Length - 1);
                    string forceUser = inputArray[1].Substring(1, inputArray[1].Length - 1);

                    if (!padawans.ContainsKey(forceSide))
                    {
                        padawans.Add(forceSide, new List<string>());
                    }

                    bool userExists = false;

                    foreach (var item in padawans)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            userExists = true;
                        }
                    }

                    if (!userExists)
                    {
                        padawans[forceSide].Add(forceUser);
                    }

                }

                else if (p2.IsMatch(input))
                {
                    string[] inputArray = input.Split(new[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string forceUser = inputArray[0].Substring(0, inputArray[0].Length - 1);
                    string forceSide = inputArray[1].Substring(1, inputArray[1].Length - 1);

                    foreach (var item in padawans)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            item.Value.Remove(forceUser);
                        }
                    }

                    if (!padawans.ContainsKey(forceSide))
                    {
                        padawans.Add(forceSide, new List<string>());
                    }

                    padawans[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");                                                  
                }

                input = Console.ReadLine();
            }

            foreach (var item in padawans.Where(x => x.Value.Count() > 0).OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {          
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count()}");
                item.Value.Sort();
                foreach (var user in item.Value)
                {
                    Console.WriteLine($"! {user}");
                }
               
            }
        }
    }
}
