using System;
using System.Collections.Generic;

namespace PowersRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();
            List<string> powers = new List<string>()
            {
                "Bend Time",
                "Devouring Swarm",
                "Possesion",
                "Windblast",
                "Dark Vision",
                "Domino",
                "Doppelgänger",
                "Mesmerize",
                "Shadow Walk",
            };

            List<string> passives = new List<string>()
            {
                "Blood Thirst",
                "Agility",
                "Bonecharm Crafting",
                "Reflexes",
                "Shadow Kill",
                "Strength",
                "Vitality"
            };

            Console.WriteLine("Powers: ", Console.ForegroundColor = ConsoleColor.Blue);
            var listOfPowers = randomizer.RandomizePowers(powers);
            DisplayPowers(listOfPowers);
            Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);

            Console.WriteLine("Passives: ", Console.ForegroundColor = ConsoleColor.Red);
            var listOfPassives = randomizer.RandomizePassives(passives);
            DisplayPowers(listOfPassives);
            Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);
        }

        private static void DisplayPowers(List<string> listOfPowers)
        {
            foreach (var power in listOfPowers)
            {
                Console.WriteLine($"{power}");
            }
        }
    }
}
