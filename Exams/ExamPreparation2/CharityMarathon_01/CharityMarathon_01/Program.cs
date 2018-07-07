using System;

namespace CharityMarathon_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfMarathon = int.Parse(Console.ReadLine());
            int numberOfParticipatedRunners = int.Parse(Console.ReadLine());
            int averageNOfLaps = int.Parse(Console.ReadLine());
            int lengthOfTrack = int.Parse(Console.ReadLine());
            long capacityOfTrack = long.Parse(Console.ReadLine());
            decimal moneyDonatedPerKm = decimal.Parse(Console.ReadLine());

            capacityOfTrack *= lengthOfMarathon;

            long totalRunners = Math.Min(numberOfParticipatedRunners, capacityOfTrack);
            decimal totalMeters = totalRunners * averageNOfLaps * lengthOfTrack;
            decimal totalKm = totalMeters / 1000;
            decimal moneyRaised = totalKm * moneyDonatedPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
