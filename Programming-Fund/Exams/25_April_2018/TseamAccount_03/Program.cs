using System;
using System.Collections.Generic;
using System.Linq;

namespace TseamAccount_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split(' ').ToList();

            string input = Console.ReadLine();

            while (input != "Play!")
            {
                string[] command = input.Split(' ').ToArray();

                switch (command[0])
                {
                    case "Install":

                        if (!games.Contains(command[1]))
                        {
                            games.Add(command[1]);
                        }
                        break;
                    case "Uninstall":

                        if (games.Contains(command[1]))
                        {
                            games.Remove(command[1]);
                        }

                        break;

                    case "Update":

                        if (games.Contains(command[1]))
                        {
                            games.Remove(command[1]);
                            games.Add(command[1]);
                        }

                        break;

                    case "Expansion":

                        string[] getGameAndExpansion = command[1].Split('-').ToArray();
                        string game = getGameAndExpansion[0];
                        string expansion = getGameAndExpansion[1];

                        if (games.Contains(game))
                        {
                            var getIndex = games.IndexOf(game);
                            games.Insert(getIndex + 1, $"{game}:{expansion}");
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < games.Count(); i++)
            {
                Console.Write(games[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
