using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects_09
{
    class Team
    {
        public string TeamName;
        public List<string> Members = new List<string>();
        public string CreatorName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> allTeams = new List<Team>();
            int lengthOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < lengthOfTeams; i++)
            {
                Team createTeam = new Team();
                string[] currentTeam = Console.ReadLine().Split('-').ToArray();
                string creatorName = currentTeam[0];
                string teamName = currentTeam[1];

                createTeam.CreatorName = creatorName;
                createTeam.TeamName = teamName;

                if (allTeams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (allTeams.Any(x => x.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {createTeam.TeamName} has been created by {createTeam.CreatorName}!");
                    allTeams.Add(createTeam);
                }
            }

            while (true)
            {
                var input = Console.ReadLine().Split('-').ToArray();

                if(input[0] == "end of assignment")
                {
                    break;
                }

                string member = input[0];
                string teamName = input[1].Substring(1, input[1].Length - 1);

                if(!allTeams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    var existingTeam = allTeams.First(x => x.TeamName == teamName);
                    if(!existingTeam.Members.Any(x => x == member) 
                        && !allTeams.Any(x => x.Members.Any(y => y == member)) 
                        && !allTeams.Any(x => x.CreatorName == member))
                    {
                        existingTeam.Members.Add(member);
                    }
                    else
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                }
            }

            List<string> TeamsToDisband = new List<string>();

            foreach (var item in allTeams.OrderByDescending(x => x.Members.Count()).ThenBy(x => x.TeamName))
            {
                if(item.Members.Count() == 0)
                {
                    TeamsToDisband.Add(item.TeamName);
                }
                else
                {
                    Console.WriteLine(item.TeamName);
                    Console.WriteLine($"- {item.CreatorName}");
                    foreach (var member in item.Members.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var item in TeamsToDisband.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
