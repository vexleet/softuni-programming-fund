using System;

namespace HelloName_01
{
    class Program
    {
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SayHello(name);
        }
    }
}
