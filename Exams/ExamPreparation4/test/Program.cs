using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FootballStandings_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Standings> allTeams = new List<Standings>();
            string decryptionKey = Regex.Escape(Console.ReadLine());
            string patternForTeams = $"({decryptionKey}(.+?){decryptionKey})";
            string patternForScore = @"(\d+):(\d+)";
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "final")
            {

                var teamAMatch = Regex.Match(input[0], patternForTeams);
                var teamBMatch = Regex.Match(input[1], patternForTeams);
                var teamsScore = Regex.Match(input[2], patternForScore);

                string teamA = string.Join("", teamAMatch.Groups[2].Value.Reverse()).ToUpper();
                string teamB = string.Join("", teamBMatch.Groups[2].Value.Reverse()).ToUpper();

                long teamAScore = long.Parse(teamsScore.Groups[1].Value);
                long teamBScore = long.Parse(teamsScore.Groups[2].Value);

                int teamAPoints = 0;
                int teamBPoints = 0;

                if (teamAScore > teamBScore)
                {
                    teamAPoints = 3;
                }
                else if (teamAScore < teamBScore)
                {
                    teamBPoints = 3;
                }
                else
                {
                    teamAPoints = 1;
                    teamBPoints = 1;
                }

                if (!allTeams.Any(x => x.TeamName == teamA))
                {
                    Standings createNewTeam = new Standings();
                    createNewTeam.TeamName = teamA;
                    createNewTeam.Goals += teamAScore;
                    createNewTeam.Points += teamAPoints;

                    allTeams.Add(createNewTeam);
                }
                else
                {
                    Standings existingTeam = allTeams.First(x => x.TeamName == teamA);

                    existingTeam.Goals += teamAScore;
                    existingTeam.Points += teamAPoints;
                }

                if (!allTeams.Any(x => x.TeamName == teamB))
                {
                    Standings createNewTeam = new Standings();
                    createNewTeam.TeamName = teamB;
                    createNewTeam.Goals += teamBScore;
                    createNewTeam.Points += teamBPoints;

                    allTeams.Add(createNewTeam);
                }
                else
                {
                    Standings existingTeam = allTeams.First(x => x.TeamName == teamB);

                    existingTeam.Goals += teamBScore;
                    existingTeam.Points += teamBPoints;
                }



                input = Console.ReadLine().Split(' ');
            }

            var place = 1;
            Console.WriteLine("League standings:");
            foreach (var item in allTeams.OrderByDescending(x => x.Points))
            {
                Console.WriteLine($"{place}. {item.TeamName} {item.Points}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");
            int counter = 1;
            foreach (var item in allTeams.OrderByDescending(x => x.Goals).ThenBy(x => x.TeamName))
            {
                Console.WriteLine($"- {item.TeamName} -> {item.Goals}");
                if (counter == 3) { break; }
                counter++;
            }

        }
    }

    class Standings
    {
        public string TeamName;
        public int Points = 0;
        public long Goals = 0;
    }
}
