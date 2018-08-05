using System;

namespace Choose_a_Drink_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = Console.ReadLine();
            
            if(person == "Athlete") {
                Console.WriteLine("Water");
            }
            else if(person == "Businessman" || person == "Businesswoman"){
                Console.WriteLine("Coffee");
            }
            else if(person == "SoftUni Student") {
                Console.WriteLine("Beer");
            }
            else {
                Console.WriteLine("Tea");
            }
        }
    }
}
