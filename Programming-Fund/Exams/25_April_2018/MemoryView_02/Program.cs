using System;
using System.Linq;

namespace MemoryView_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startingStrings = { "32656", "19759", "32763" };
            int startingStringsCounter = 0;
            int stringLength = 0;
            string getString = "";

            while (true)
            {
                string input = Console.ReadLine();
                if(input ==  "Visual Studio crash")
                {
                    break;
                }
                string[] allCharacters = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < allCharacters.Length; i++)
                {

                    if (allCharacters[i] == "0")
                    {
                        continue;
                    }

                    if (startingStringsCounter == 3)
                    {
                        int j = i + 1;
                        if(stringLength == 0)
                        {
                            stringLength = int.Parse(allCharacters[i]);
                        }
                        else
                        {
                            j = 0;
                        }

                        for (; j < allCharacters.Length; j++)
                        {
                            if (allCharacters[j] == "0") continue;

                            int currentChar = int.Parse(allCharacters[j]);
                            getString += (char)currentChar;

                            if(getString.Length == stringLength)
                            {
                                Console.WriteLine(getString);
                                startingStringsCounter = 0;
                                stringLength = 0;
                                getString = "";
                                break;
                            }
                        }
                        i = j;
                        continue;
                    }

                    if(allCharacters[i] != startingStrings[startingStringsCounter])
                    {
                        startingStringsCounter = 0;
                    }

                    if (allCharacters[i] == startingStrings[startingStringsCounter])
                    {
                        startingStringsCounter++;
                    }
                }
            }
        }
    }
}
