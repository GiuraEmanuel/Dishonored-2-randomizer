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

            Console.WriteLine("Powers: ", Console.ForegroundColor = ConsoleColor.Blue);
            var listOfPowers = RandomizePowers(powers);
            DisplayPowers(listOfPowers);

            //Console.WriteLine();
            //Console.WriteLine("Passives: ", Console.ForegroundColor = ConsoleColor.Red);
            //var listOfPassives = RandomizePassives(passives);
            //DisplayPowers(listOfPassives);
        }

        private static List<string> RandomizePowers(List<string> powers)
        {
            List<string> result = new List<string>();
            Random random = new Random();


            for (int i = 0; i < 3; i++)
            {
                var shuffledPowerList = Shuffle(powers);
                if (!result.Contains(shuffledPowerList[0]))
                {
                    result.Add(shuffledPowerList[0]);
                }
            }
            return result;
        }

        private static List<string> Shuffle(List<string> listToShuffle)
        {
            Random r = new Random();
            List<string> shuffledList = new List<string>();
            for (int n = listToShuffle.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                var temp = listToShuffle[n];
                listToShuffle[n] = listToShuffle[k];
                listToShuffle[k] = temp;
                shuffledList.Add(listToShuffle[k]);
            }
            return shuffledList;
        }

        private static List<string> RandomizePassives(List<string> passives)
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

        private static void DisplayPowers(List<string> listOfPowers)
        {
            foreach (var power in listOfPowers)
            {
                Console.WriteLine($"{power}");
            }
        }
    }
}
