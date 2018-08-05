using System;
using System.Collections.Generic;

namespace FixEmails_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            string input = Console.ReadLine();
            int counter = 1;
            string currentName = "";
            string emailOfCurrentName = "";

            while (input != "stop")
            {
                if (counter % 2 == 1)
                {
                    currentName = input;
                }
                else
                {
                    emailOfCurrentName = input;
                    string[] splitString = emailOfCurrentName.Split('.');
                    string domainName = splitString[splitString.Length - 1];

                    if(domainName.ToLower() != "us" && domainName.ToLower() != "uk")
                    {
                        emails.Add(currentName, emailOfCurrentName);
                    }
                }
                counter++;
                input = Console.ReadLine();
            }

            foreach (var pair in emails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
