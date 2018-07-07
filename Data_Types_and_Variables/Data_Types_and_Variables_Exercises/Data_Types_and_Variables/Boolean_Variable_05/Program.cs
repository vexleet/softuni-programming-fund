using System;

namespace Boolean_Variable_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string getBolean = Console.ReadLine();
            bool answer = Convert.ToBoolean(getBolean);
            
            if(answer == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
