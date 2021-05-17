using System;
namespace PowersRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();

            Set set = new();
            randomizer.RandomizePowers(set);
            randomizer.RandomizePassives(set);
            DisplayPowers(set);

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
