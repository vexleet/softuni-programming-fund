using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs_06
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(new char[] { '=', ' ' });
            int counter = 0;

            while(input[0] != "end")
            {
                string ip = input[1];
                string user = input[input.Length - 1];

                if (users.ContainsKey(user) == false)
                {
                    users.Add(user, new Dictionary<string, int>());
                }
               
                if(users[user].ContainsKey(ip) == false)
                {
                    users[user].Add(ip, 1);
                }
                else
                {
                    users[user][ip] += 1;
                }
                

                input = Console.ReadLine().Split(new char[] { '=', ' ' });
            }

            var list = users.Keys.ToList();
            list.Sort();

            foreach (var pair in list)
            {
                Console.WriteLine($"{pair}: ");
                foreach (var ip in users[pair])
                {
                    if(counter < users[pair].Count() - 1)
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");                       
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}.");
                    }
                    counter++;
                }
                Console.WriteLine();
                counter = 0;
            }

        }
    }
}
