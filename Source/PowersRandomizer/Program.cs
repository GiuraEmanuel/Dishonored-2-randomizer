using System;
using System.Collections.Generic;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Powers: ",Console.ForegroundColor = ConsoleColor.Blue);
            var listOfPowers = RandomizePowers(powers);
            DisplayPowers(listOfPowers);

            Console.WriteLine();
            Console.WriteLine("Passives: ", Console.ForegroundColor = ConsoleColor.Red);
            var listOfPassives = RandomizePassives(passives);
            DisplayPowers(listOfPassives);
        }

        public static List<string> RandomizePowers(List<string> powers)
        {
            List<string> result = new List<string>();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                var randomNumber = random.Next(0, powers.Count - 1);
                string power = powers[randomNumber];
                result.Add(power);
            }
            return result;
        }

        public static List<string> RandomizePassives(List<string> passives)
        {
            List<string> result = new List<string>();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                var randomNumber = random.Next(0, passives.Count - 1);
                string passive = passives[randomNumber];
                result.Add(passive);
            }
            return result;
        }

        public static void DisplayPowers(List<string> listOfPowers)
        {
            foreach (var power in listOfPowers)
            {
                Console.WriteLine($"{power}");
            }
        }
    }
}
