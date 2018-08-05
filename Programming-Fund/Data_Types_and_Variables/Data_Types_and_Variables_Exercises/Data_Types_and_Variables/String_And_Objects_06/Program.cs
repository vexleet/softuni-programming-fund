using System;

namespace String_And_Objects_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            object concatStrings = $"{string1} {string2}";
            string result = Convert.ToString(concatStrings);

            Console.WriteLine(result);

        }
    }
}
