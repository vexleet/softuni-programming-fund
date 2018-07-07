using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([0-9]{1,2}.[0-9]{1,2})([A-Za-z]+)\|";
            string input = Console.ReadLine();
            Dictionary<string, KeyValuePair<string, double>> weather = new Dictionary<string, KeyValuePair<string, double>>();
            Regex regex = new Regex(pattern);

            while(input != "end")
            {
                
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string city = match.Groups[1].Value;
                    double averageTemperature = double.Parse(match.Groups[2].Value);
                    string typeOfWeather = match.Groups[3].Value;

                    if (!weather.ContainsKey(city))
                    {
                        weather.Add(city, new KeyValuePair<string, double>(typeOfWeather, averageTemperature));
                    }
                    else
                    {
                        weather.Remove(city);
                        weather.Add(city, new KeyValuePair<string, double>(typeOfWeather, averageTemperature));
                    }
                }

                input = Console.ReadLine();
            }

            var sortedDict = weather.OrderBy(x => x.Value.Value).ToDictionary(x => x.Key, x => x.Value);


            foreach (var d in sortedDict)
            {
                Console.WriteLine($"{d.Key} => {d.Value.Value:f2} => {d.Value.Key}");
            }

        }
    }
}
