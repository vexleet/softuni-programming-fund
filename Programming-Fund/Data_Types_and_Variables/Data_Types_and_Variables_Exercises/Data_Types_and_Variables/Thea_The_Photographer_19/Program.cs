using System;

namespace Thea_The_Photographer_19
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong picsTaken = ulong.Parse(Console.ReadLine());
            ulong timeToFilterASinglePic = ulong.Parse(Console.ReadLine());
            decimal goodPics = decimal.Parse(Console.ReadLine());
            ulong timeForFilteredPics = ulong.Parse(Console.ReadLine());

            ulong filteredPics = Convert.ToUInt64(Math.Ceiling(picsTaken * (goodPics / 100)));
            ulong secsOfTotalPicsToFilter = picsTaken * timeToFilterASinglePic;
            ulong secsOfFilteredPicsToUpload = filteredPics * timeForFilteredPics;
            ulong totalTimeToFilter = secsOfTotalPicsToFilter + secsOfFilteredPicsToUpload;

            ulong days = totalTimeToFilter / (60 * 60 * 24);
            totalTimeToFilter -= days * (60 * 60 * 24);
            ulong hours = totalTimeToFilter / (60 * 60);
            totalTimeToFilter -= hours * (60 * 60);
            ulong minutes = totalTimeToFilter / 60;
            ulong seconds = totalTimeToFilter % 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
