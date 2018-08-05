using System;
using System.Collections.Generic;

namespace Different_Int_Types_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine(); ;
            int counter = 0;
            List<string> numbers = new List<string>();

            try
            {
                sbyte check = sbyte.Parse(num);
                numbers.Add("* sbyte");
            }
            catch(Exception)
            {
            }
            try
            {
                byte check = byte.Parse(num);
                numbers.Add("* byte");

            }
            catch (Exception)
            {
            }
            try
            {
                short check = short.Parse(num);
                numbers.Add("* short");
            }
            catch (Exception)
            {
            }
            try
            {
                ushort check = ushort.Parse(num);
                numbers.Add("* ushort");
            }
            catch (Exception)
            {
            }
            try
            {
                int check = int.Parse(num);
                numbers.Add("* int");
            }
            catch (Exception)
            {
            }
            try
            {
                uint check = uint.Parse(num);
                numbers.Add("* uint");
            }
            catch (Exception)
            {
            }
            try
            {
                long check = long.Parse(num);
                numbers.Add("* long");
            }
            catch (Exception)
            {
            }

            if(numbers.Count > 0)
            {
                Console.WriteLine($"{num} can fit in:");
                Console.WriteLine(string.Join("\n", numbers));
            }
            else
            {
                Console.WriteLine($"{num} can't fit in any type");
            }
        }
    }
}
