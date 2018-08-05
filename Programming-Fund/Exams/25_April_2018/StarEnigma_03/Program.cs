using System;
using System.Collections.Generic;
using System.Linq;

namespace StarEnigma_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            List<string> decryptedMsgs = new List<string>();
            char[] letters = { 's', 't', 'a', 'r' };
            int validMessageCounter = 0;


            int numberOfMsg = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMsg; i++)
            {
                string currentMsg = Console.ReadLine();
                int countStar = 0;
                string getdecryptedMsg = "";

                for (int j = 0; j < currentMsg.Length; j++)
                {
                    if (letters.Contains(char.ToLower(currentMsg[j])))
                    {
                        countStar++;
                    }
                }

                for (int j = 0; j < currentMsg.Length; j++)
                {
                    int currentLetter = currentMsg[j] - countStar;
                    getdecryptedMsg += (char)currentLetter;
                }
                decryptedMsgs.Add(getdecryptedMsg);
            }

            for (int i = 0; i < decryptedMsgs.Count(); i++)
            {
                string planet = "";
                char planetType = new char();
                bool availableName = false;

                for (int j = 0; j < decryptedMsgs[i].Length; j++)
                {
                    if (decryptedMsgs[i][j] == '@')
                    {
                        var lettersCounter = j;
                        while(true)
                        {
                            char currentLetter = decryptedMsgs[i][lettersCounter + 1];
                            if ((currentLetter >= 65 && currentLetter <= 90) || (currentLetter >= 97 && currentLetter <= 122))
                            {
                                planet += currentLetter;
                                lettersCounter++;
                                availableName = true;
                            }
                            else
                            {
                                if (availableName) validMessageCounter++;
                                j = lettersCounter - 1;
                                break;
                            }
                        }
                        
                    }

                    else if(decryptedMsgs[i][j] == ':')
                    {
                        string[] planetPopulation = decryptedMsgs[i].Split(new[] { ':', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                        string num = "";

                        for (int k = 0; k < planetPopulation[1].Length; k++)
                        {
                            if (int.TryParse(planetPopulation[1][k].ToString(), out int result) == true)
                            {
                                num += result;
                            }
                        }
                        if(num != "")
                        {
                            validMessageCounter++;
                            j += planetPopulation[1].Length;
                        }                      
                    }

                    else if(decryptedMsgs[i][j] == '!' && decryptedMsgs[i][j + 2] == '!')
                    {
                        if(decryptedMsgs[i][j + 1] == 'A')
                        {
                            planetType = 'A';
                            validMessageCounter++;
                            j += 2;
                        }
                        else if(decryptedMsgs[i][j + 1] == 'D')
                        {
                            planetType = 'D';
                            validMessageCounter++;
                        }
                    }

                    else if(decryptedMsgs[i][j] == '-' &&decryptedMsgs[i][j + 1] == '>')
                    {
                        string[] soliderCount = decryptedMsgs[i].Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                        string num = "";

                        for (int k = 0; k < soliderCount[1].Length; k++)
                        {
                            if (int.TryParse(soliderCount[1][k].ToString(), out int result) == true)
                            {
                                num += result;
                            }
                        }
                        if (num != "")
                        {
                            validMessageCounter++;
                            j += soliderCount[1].Length;
                        }
                    }
                }
                
                if(validMessageCounter == 4)
                {
                    if(planetType == 'A')
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if(planetType == 'D')
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
                validMessageCounter = 0;
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count()}");
            attackedPlanets.Sort();
            foreach (var item in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
            destroyedPlanets.Sort();
            foreach (var item in destroyedPlanets)
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
