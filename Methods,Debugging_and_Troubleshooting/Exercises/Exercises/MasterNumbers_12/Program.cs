using System;

namespace MasterNumbers_12
{
    class Program
    {
        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if(sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i]) { return false; }
            }
            return true;
        }

            static bool ContainsEvenDigit(int num)
        {
            string str = num.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                int currentDigit = int.Parse(str[i].ToString());
                if(currentDigit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (var i = 1; i <= num; i++)
            {
                if (IsPalindrome(i.ToString()) == true && SumOfDigits(i) == true && ContainsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

            
