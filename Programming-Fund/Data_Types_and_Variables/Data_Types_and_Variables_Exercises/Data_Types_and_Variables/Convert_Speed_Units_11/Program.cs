using System;

namespace Convert_Speed_Units_11
{
    class Program
    {
        static void Main(string[] args)
        {
            uint meters = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds);

            float metersPerSec = (float)meters / time;
            float kmPerHour = ((float)meters / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)meters / 1609) / ((float)time / 3600);

            Console.WriteLine("{0:0.#######}", metersPerSec);
            Console.WriteLine("{0:0.#######}", kmPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);

        }
    }
}
