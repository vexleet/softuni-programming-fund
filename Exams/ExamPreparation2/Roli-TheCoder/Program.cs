using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Roli_TheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Event> roliEvents = new List<Event>();
            while(input != "Time for Code")
            {
                if(Regex.IsMatch(input, @"(\d)\s#([A-Za-z]+)($|(?=\s))"))
                {
                    string id = Regex.Match(input, @"(\d)\s#([A-Za-z]+)").Groups[1].Value;
                    string name = Regex.Match(input, @"(\d)\s#([A-Za-z]+)").Groups[2].Value;
                    List<string> participants = Regex.Matches(input, @"@[A-Za-z'-]+").Cast<Match>().Select(x => x.Value).ToList();
                    
                    if(!roliEvents.Any(x => x.ID == id))
                    {
                        roliEvents.Add(new Event { ID = id, Name = name, Participants = new SortedSet<string>(participants) });
                    }
                    else
                    {
                        Event ev = roliEvents.First(x => x.ID == id);

                        foreach (var item in participants)
                        {
                            
                            ev.Participants.Add(item);
                            
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in roliEvents.OrderByDescending(x => x.Participants.Count()).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Participants.Count()}");
                foreach (var part in item.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(part);
                }
            }
        }

        class Event
        {
            public string ID;
            public string Name;
            public SortedSet<string> Participants;
        }
    }
}
