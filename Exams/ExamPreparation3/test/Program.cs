using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Files_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfroots = int.Parse(Console.ReadLine());
            List<string> allRoots = new List<string>();
            Dictionary<string, long> appearedFiles = new Dictionary<string, long>();

            for (int i = 0; i < numberOfroots; i++)
            {
                allRoots.Add(Console.ReadLine());
            }

            var query = Console.ReadLine().Split();
            string requiredRoot = query[2];
            string extension = query[0];

            for (int i = 0; i < allRoots.Count(); i++)
            {
                var currentRoot = allRoots[i].Split('\\');
                string root = currentRoot[0];

                if (root == requiredRoot)
                {
                    var lastFile = currentRoot[currentRoot.Length - 1];

                    if (Regex.IsMatch(lastFile, $@".+(\.{extension})"))
                    {
                        var getFile = lastFile.Split(';');
                        string name = getFile[0];
                        long size = long.Parse(getFile[1]);

                        if (!appearedFiles.ContainsKey(name))
                        {
                            appearedFiles.Add(name, size);
                        }
                        else
                        {
                            appearedFiles.Remove(name);
                            appearedFiles.Add(name, size);
                        }
                    }
                }
            }

            if (appearedFiles.Count() == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach (var item in appearedFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value} KB");
            }
        }
    }
}
