using System;

namespace Centuries_Nanoseconds_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            double years = century * 100.0;
            int days = Convert.ToInt32(Math.Floor(years * 365.2422));
            int hours = Convert.ToInt32(days * 24);
            long minutes = Convert.ToInt64(hours * 60);
            double seconds = minutes * 60;
            decimal milliseconds = Convert.ToDecimal(seconds * 1000);
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{century} centuries = {years} years = {days:F0} days = {hours:F0} hours = " +
                $"{minutes:F0} minutes = {seconds:F0} seconds = {milliseconds:F0} milliseconds = " +
                $"{microseconds:F0} microseconds = {nanoseconds:F0} nanoseconds");
        }
    }
}
