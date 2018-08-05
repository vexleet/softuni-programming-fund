using System;
using System.Collections.Generic;

namespace PhoneBook_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebookEntries = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "END")
            {
                if(input[0] == "A")
                {
                    string name = input[1];
                    string phonenumber = input[2];

                    if(phonebookEntries.ContainsKey(name))
                    {
                        phonebookEntries.Remove(name);
                    }

                    phonebookEntries.Add(name, phonenumber);
                }
                else if(input[0] == "S")
                {
                    string checkName = input[1];

                    if(phonebookEntries.TryGetValue(checkName, out string phoneNumber))
                    {
                        Console.WriteLine($"{checkName} -> {phoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {checkName} does not exist.");
                    }
                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
