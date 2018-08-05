using System;

namespace Print_The_ASCII_Table_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());

            for(var i = firstChar; i<=lastChar; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
        }
    }
}
