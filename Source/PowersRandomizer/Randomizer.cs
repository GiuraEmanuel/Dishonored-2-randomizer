using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Random r = new Random();
            var shuffledPowers = powers.OrderBy(p => r.Next());

            foreach (var power in shuffledPowers.Take(3))
            {
                powerSet.Powers.Add(power);
            }
        }

        public void RandomizePassives(Set passivesSet)
        {
            Random r = new Random();
            var shuffledPassives = passives.OrderBy(p => r.Next());

            foreach (var passive in shuffledPassives.Take(3))
            {
                passivesSet.Passives.Add(passive);
            }
        }

        public void SaveToFile(Set setToSave)
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            dirPath = Path.Combine(dirPath, "Dishonored 2 Randomizer");
            Directory.CreateDirectory(dirPath);
            var filePath = Path.Combine(dirPath, "Data.txt");

            var data = new Data();
            data.Sets.Add(setToSave);

            JsonSerializerOptions options = new() { WriteIndented = true };
            string json = JsonSerializer.Serialize(data, options);
            File.AppendAllText(filePath, json);
        }
    }
}
