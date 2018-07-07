using System;

namespace Character_Sets_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int healthLeft = maxHealth - currentHealth;
            int energyLeft = maxEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', healthLeft)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', energyLeft)}|");

        }
    }
}
