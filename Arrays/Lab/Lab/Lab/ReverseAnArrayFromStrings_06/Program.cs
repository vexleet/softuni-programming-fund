using System;
using System.Linq;
namespace ReverseAnArrayFromStrings_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ');
            var reversedArray = array.Reverse();

            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}
