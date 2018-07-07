using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MOBAChallenger_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternForPlayers = @"(.+?) -> (.+?) -> (\d+)";
            string patternForFighting = @"(.+)? vs (.+$)";
            List<Player> allPlayers = new List<Player>();

            string input = Console.ReadLine();

            while(input != "Season end")
            {
                if(Regex.IsMatch(input, patternForPlayers))
                {
                    Match currentPlayer = Regex.Match(input, patternForPlayers);

                    string name = currentPlayer.Groups[1].Value;
                    string position = currentPlayer.Groups[2].Value;
                    int skill = int.Parse(currentPlayer.Groups[3].Value);

                    if (!allPlayers.Any(x => x.playerName == name))
                    {
                        Player newPlayer = new Player();

                        newPlayer.playerName = name;
                        newPlayer.positionAndSkill = new Dictionary<string, int>();
                        newPlayer.positionAndSkill.Add(position, skill);

                        allPlayers.Add(newPlayer);
                    }
                    else
                    {
                        Player existingPlayer = allPlayers.Find(x => x.playerName == name);

                        if (existingPlayer.positionAndSkill.ContainsKey(position))
                        {
                            if(existingPlayer.positionAndSkill[position] <= skill)
                            {
                                existingPlayer.positionAndSkill[position] = skill;
                            }
                        }
                        else
                        {
                            existingPlayer.positionAndSkill.Add(position, skill);
                        }
                    }

                }

                else if(Regex.IsMatch(input, patternForFighting))
                {
                    Match fightingPlayers = Regex.Match(input, patternForFighting);
                    string firstFighterName = fightingPlayers.Groups[1].Value;
                    string secondFighterName = fightingPlayers.Groups[2].Value;

                    if (allPlayers.Any(x => x.playerName == firstFighterName) && allPlayers.Any(x => x.playerName == secondFighterName))
                    {
                        Player firstFighter = allPlayers.First(x => x.playerName == firstFighterName);
                        Player secondFighter = allPlayers.First(x => x.playerName == secondFighterName);

                        bool playersExist = false;

                        foreach (var item in firstFighter.positionAndSkill)
                        {
                            if (secondFighter.positionAndSkill.ContainsKey(item.Key))
                            {
                                playersExist = true;
                                break;
                            }
                        }

                        if (!playersExist)
                        {
                            input = Console.ReadLine();
                            continue;
                        }

                        int firstFighterSkills = firstFighter.positionAndSkill.Values.Sum();
                        int secondFigherSkills = secondFighter.positionAndSkill.Values.Sum();

                        if (firstFighterSkills > secondFigherSkills)
                        {
                            allPlayers.Remove(secondFighter);
                        }
                        else if (firstFighterSkills < secondFigherSkills)
                        {
                            allPlayers.Remove(firstFighter);
                        }                       
                    }
                }
                

                input = Console.ReadLine();
            }

            foreach (var item in allPlayers.OrderByDescending(x => x.positionAndSkill.Values.Sum()).ThenBy(x => x.playerName))
            {
                int totalSkill = item.positionAndSkill.Values.Sum();

                Console.WriteLine($"{item.playerName}: {totalSkill} skill");

                foreach (var position in item.positionAndSkill.OrderByDescending(x => x.Value).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }

        }
    }

    class Player
    {
        public string playerName;
        public Dictionary<string, int> positionAndSkill;
    }

}
