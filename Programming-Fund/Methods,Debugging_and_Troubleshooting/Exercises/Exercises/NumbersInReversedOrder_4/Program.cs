using System;

namespace NumbersInReversedOrder_4
{
    class Program
    {
        static void ReverseNumber(string num)
        {
            string result = "";
            while (num.Length > 0)
            {
                string lastDigit = num.Substring(num.Length - 1);
                result += lastDigit;
                num = num.Remove(num.Length - 1);

            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            ReverseNumber(num);
        }
    }
}
