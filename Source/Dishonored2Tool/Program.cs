using System;
namespace Dishonored2Tool
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static void DisplayPowers(Set set)
        {
            foreach (var power in set.Powers)
            {
                Console.WriteLine($"{power}");
            }

            Console.WriteLine();

            foreach (var passive in set.Passives)
            {
                Console.WriteLine($"{passive}");
            }
        }
    }
}
