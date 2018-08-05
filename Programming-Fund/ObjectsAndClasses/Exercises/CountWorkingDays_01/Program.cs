using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CountWorkingDays_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int workingDays = 0;
            DateTime[] holidays = new DateTime[]
            {
                DateTime.ParseExact("01-01", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12", "dd-MM", CultureInfo.InvariantCulture),
            };

            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var checkForHoliday = holidays.Any(x => x.Day == i.Day && x.Month == i.Month);

                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday || checkForHoliday)
                {
                    continue;
                }
                workingDays++;

            }
            Console.WriteLine(workingDays);
        }
    }
}
