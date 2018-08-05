using System;

namespace Number_Checker_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
