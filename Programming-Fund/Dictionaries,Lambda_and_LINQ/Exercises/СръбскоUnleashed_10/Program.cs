using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace СръбскоUnleashed_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> singersAndVenues = new Dictionary<string, Dictionary<string, long>>();

            const string pattern = @"(.*?) @(.*?) (\d+) (\d+)";
            string input = Console.ReadLine();
            string[] inputArray = input.Split('@').ToArray();

            while(inputArray[0] != "End")
            {
                string singer = inputArray[0];
                List<string> aboutSinger = JoinStrings(inputArray[1].Split(' '));
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    inputArray = input.Split('@').ToArray();
                    continue;
                }
                if (aboutSinger.Count() < 3)
                {
                    inputArray = Console.ReadLine().Split('@').ToArray();
                    continue;
                }
                string venue = aboutSinger[0];
                long ticketPrice = long.Parse(aboutSinger[1]);
                long ticketCount = long.Parse(aboutSinger[2]);
                long countTotal = ticketPrice * ticketCount;

                if (!singersAndVenues.ContainsKey(venue))
                {
                    singersAndVenues.Add(venue, new Dictionary<string, long>());
                }
                if (!singersAndVenues[venue].ContainsKey(singer))
                {
                    singersAndVenues[venue].Add(singer, 0);
                }
                singersAndVenues[venue][singer] += countTotal;
                input = Console.ReadLine();
                inputArray = input.Split('@').ToArray();
            }

            foreach (var venue in singersAndVenues)
            {
                Console.WriteLine(venue.Key);

                var sortedSingers = venue.Value
                    .OrderByDescending(s => s.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var singer in sortedSingers)
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }

        }

        static List<string> JoinStrings(string[] array)
        {
            List<string> name = new List<string>();
            List<string> resultList = new List<string>();

            for (long i = 0; i < array.Length; i++)
            {
                if (!long.TryParse(array[i], out long result))
                {
                    name.Add(array[i]); 
                    continue;
                }
                else
                {
                    resultList.Add(array[i]);
                }
            }
            string finalName = string.Join(" ", name);
            resultList.Insert(0, finalName);

            return resultList;
        }

    }
}
