using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<long, List<string>>> logs = new Dictionary<string, Dictionary<long, List<string>>>();

            long lengthOfLogs = long.Parse(Console.ReadLine());

            for (long i = 0; i < lengthOfLogs; i++)
            {
                string[] currentLog = Console.ReadLine().Split(' ');

                string currentIp = currentLog[0];
                string currentUser = currentLog[1];
                long duration = long.Parse(currentLog[2]);

                if(logs.ContainsKey(currentUser) == false)
                {
                    logs.Add(currentUser, new Dictionary<long, List<string>>());
                    logs[currentUser].Add(duration, new List<string>());
                    logs[currentUser][duration].Add(currentIp);
                }
                else
                {
                    var keys = duration;
                    var values = new List<string>();
                    values.Add(currentIp);
                    bool check = false;
                    long currentKey = 0;

                    foreach (var pair in logs[currentUser])
                    {
                        if(check == false)
                        {
                            keys += pair.Key;
                            currentKey = pair.Key;
                            check = true;
                        }
                        foreach (var ip in pair.Value)
                        {
                            values.Add(ip);

                        }
                    }

                    logs[currentUser].Remove(currentKey);
                    logs[currentUser].Add(keys, values);
                }

            }

            var list = logs.Keys.ToList();
            list.Sort();

            foreach (var item in list)
            {
                var getIps = logs[item].Values.ToList();
                getIps[0].Sort();
                foreach (var value in logs[item])
                {
                    Console.WriteLine($"{item}: {value.Key} [{string.Join(", ", getIps[0].Distinct())}]");
                }
            }
        }
    }
}
