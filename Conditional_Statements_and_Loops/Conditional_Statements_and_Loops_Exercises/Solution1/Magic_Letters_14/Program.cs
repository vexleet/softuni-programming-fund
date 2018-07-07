using System;

namespace Magic_Letters_14
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char specialLetter = char.Parse(Console.ReadLine());
            string result = "";

            for(var i = firstLetter; i<=secondLetter; i++)
            {
                for(var j = firstLetter; j<=secondLetter; j++)
                {
                    for(var k = firstLetter; k <= secondLetter; k++)
                    {
                        if(i != specialLetter && j != specialLetter && k != specialLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
