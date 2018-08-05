using System;

namespace Interval_of_Numbers_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int start = 0;
            int finish = 0;

            if(firstN > secondN)
            {
                start = secondN;
                finish = firstN;
            }
            else
            {
                start = firstN;
                finish = secondN;
            }

            for(int i = start; i<= finish; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
