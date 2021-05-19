using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PowersRandomizer
{

    public class Randomizer
    {
        // Ranks powers and passives based on their "inborn" lethality 
        // 1 - nonlethal
        // 5 - lethal
        // 2.5 - these abilities can be used for both lethal and nonlethal play
        // 0 - can't be ranked
        private Dictionary<string, double> abilitiesToRankLookUp = new Dictionary<string, double>()
        {
            { "Bend Time", 2.5},
            { "Devouring Swarm", 5},
            { "Possesion" , 2.5},
            { "Windblast", 5},
            { "Dark Vision", 1},
            { "Domino", 1},
            { "Doppelgänger", 2.5},
            { "Mesmerize", 2.5},
            { "Shadow Walk", 2.5},
            { "Blood Thirst",5 },
            { "Agility", 0},
            {"Bonecharm Crafting",2.5 },
            { "Reflexes", 5},
            { "Shadow Kill", 5},
            { "Strength", 0},
            { "Vitality", 0}
        };

        List<string> nonLethalAbilities = new List<string>()
        {
            "Bend Time",
            "Possesion",
            "Dark Vision",
            "Domino",
            "Doppelgänger",
            "Mesmerize",
            "Shadow Walk",
            "",
            "",
            "",
            "",
            "",
        };

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
