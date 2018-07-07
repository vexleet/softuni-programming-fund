using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' , '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Length == 20)
                {
                    string ticket = input[i];
                    string firstHalf = input[i].Substring(0, 10);
                    input[i] = input[i].Remove(0, 10);
                    string secondHalf = input[i];

                    firstHalf = Regex.Match(firstHalf, @"[@#\$\^]+").ToString();
                    secondHalf = Regex.Match(secondHalf, @"[@#\$\^]+").ToString();

                    if ((firstHalf + secondHalf).Distinct().Count() == 1 && (firstHalf.Length + secondHalf.Length) == 20)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{firstHalf[0]} Jackpot!");
                        continue;
                    }

                    int counterMonkey = 1;
                    int counterHash = 1;
                    int counterMoney = 1;
                    int counterArrow = 1;

                    for (int j = 1; j < firstHalf.Length; j++)
                    {
                        if(firstHalf[j] == '@' && firstHalf[j - 1] == '@'){counterMonkey++;}
                        else { counterMonkey = 0; }
                        if (firstHalf[j] == '#' && firstHalf[j - 1] == '#') { counterHash++; }
                        else { counterHash = 0; }
                        if(firstHalf[j] == '$' && firstHalf[j - 1] == '$') {counterMoney++;}
                        else { counterMoney = 0; }
                        if(firstHalf[j] == '^' && firstHalf[j - 1] == '^') {counterArrow++;}
                        else { counterArrow = 0;}
                    }

                    counterMonkey += 1;
                    counterHash += 1;
                    counterMoney += 1;
                    counterArrow += 1;

                    for (int j = 1; j < secondHalf.Length; j++)
                    {
                        if (secondHalf[j] == '@' && secondHalf[j - 1] == '@') { counterMonkey++; }
                        else { counterMonkey = 0; }
                        if (secondHalf[j] == '#' && secondHalf[j - 1] == '#') { counterHash++; }
                        else { counterHash = 0;}
                        if (secondHalf[j] == '$' && secondHalf[j - 1] == '$') { counterMoney++; }
                        else { counterMoney = 0; }
                        if (secondHalf[j] == '^' && secondHalf[j - 1] == '^') { counterArrow++; }
                        else { counterArrow = 0; }
                    }

                        if (counterMonkey / 2 >= 6 && counterMonkey / 2 <= 9)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {counterMonkey/2}@");
                    }
                    else if (counterHash / 2 >= 6 && counterHash / 2 <= 9)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {counterHash / 2}#");
                    }
                    else if (counterMoney / 2 >= 6 && counterMoney / 2 <= 9)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {counterMoney / 2}$");
                    }
                    else if (counterArrow / 2 >= 6 && counterArrow / 2 <= 9)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {counterArrow / 2}^");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}