using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> powerOfCard = new Dictionary<string, int>()
            {
                {"2", 2},
                {"3", 3},
                {"4", 4},
                {"5", 5},
                {"6", 6},
                {"7", 7},
                {"8", 8},
                {"9", 9},
                {"10", 10},
                {"J", 11},
                {"Q", 12},
                {"K", 13},
                {"A", 14}
            };

            Dictionary<string, int> powerOfType = new Dictionary<string, int>()
            {
                {"S", 4},
                {"H", 3},
                {"D", 2},
                {"C", 1}
            };

            Dictionary<string, string> drawnCardOfPlayers = new Dictionary<string, string>();

            Dictionary<string, int> players = new Dictionary<string, int>();


            string[] input = Console.ReadLine().Split(':');

            while(input[0] != "JOKER")
            {
                string name = input[0];
                List<string> cards = input[1].Split(new char[] { ',', ' '}).Distinct().ToList();

                if (drawnCardOfPlayers.ContainsKey(name) == false)
                {
                    drawnCardOfPlayers.Add(name, "");
                } 

                for (int i = 1; i < cards.Count(); i++)
                {
                    string currentHand = cards[i];
                    if (drawnCardOfPlayers[name].Contains(currentHand))
                    {
                        continue;
                    }
                    else
                    {
                        drawnCardOfPlayers[name] += " " + currentHand;
                    }

                    int currentCardPower = powerOfCard[currentHand.Substring(0, currentHand.Length - 1)];
                    int currentType = powerOfType[currentHand[currentHand.Length - 1].ToString()];
                    int powerOfDrawnHand = currentCardPower * currentType;

                    if (players.TryGetValue(name, out int currentScore))
                    {
                        int value = powerOfDrawnHand + currentScore;
                        players[name] = value;
                    }
                    else
                    {
                        players.Add(name, powerOfDrawnHand);
                    }
                }

                input = Console.ReadLine().Split(':');
            }

            foreach (var pair in players)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
