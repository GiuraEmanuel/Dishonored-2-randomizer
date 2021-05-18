using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PowersRandomizer
{
    public class Randomizer
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

        public void RandomizePowers(Set powerSet)
        {
            var shuffledPowersList = Shuffle(powers);
            for (int i = 0; i < 3; i++)
            {
                powerSet.Powers.Add(shuffledPowersList[i]);
            }
        }

        public void RandomizePassives(Set passivesSet)
        {
            var shuffledPowersList = Shuffle(passives);
            for (int i = 0; i < 3; i++)
            {
                passivesSet.Passives.Add(shuffledPowersList[i]);
            }
        }

        private List<string> Shuffle(List<string> listToShuffle)
        {
            Random r = new Random();
            List<string> shuffledList = new List<string>(listToShuffle);

            for (int n = shuffledList.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                var temp = shuffledList[n];
                shuffledList[n] = shuffledList[k];
                shuffledList[k] = temp;
            }
            return shuffledList;
        }

        public void SaveToFile(Set setToSave)
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            dirPath = Path.Combine(dirPath, "Dishonored 2 Randomizer");
            Directory.CreateDirectory(dirPath);
            var filePath = Path.Combine(dirPath, "Data.txt");

            var data = new Data();
            data.Sets.Add(setToSave);

            string json = JsonSerializer.Serialize(data);
            File.AppendAllText(filePath, json);
        }
    }
}
