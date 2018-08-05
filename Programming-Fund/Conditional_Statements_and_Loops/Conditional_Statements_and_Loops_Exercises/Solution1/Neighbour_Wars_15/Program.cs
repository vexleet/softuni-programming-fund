using System;

namespace Neighbour_Wars_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoKick = int.Parse(Console.ReadLine());
            int goshoPunch = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int recieveHealthCounter = 0;
            int roundsCounter = 0;
            int currentPlayer = 0;

            while(true)
            {
                if(currentPlayer == 0)
                {
                    goshoHealth -= peshoKick;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {roundsCounter + 1}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    currentPlayer = 1;
                }

                else if(currentPlayer == 1)
                {
                    peshoHealth -= goshoPunch;
                    if(peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {roundsCounter + 1}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    currentPlayer = 0;
                }

                recieveHealthCounter++;
                roundsCounter++;
                if(recieveHealthCounter == 3)
                {
                    recieveHealthCounter = 0;
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

            }
            
        }
    }
}
