using System;

namespace Count_The_Integers_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int x = 0;
            int counter = 0;

            while ((Int32.TryParse(number, out x)) == true)
            {
                number = Console.ReadLine();
                counter++;
            } 


            Console.WriteLine(counter);
        }
    }
}
