using System;
using System.Collections.Generic;
using System.IO;

namespace PowersRandomizer
{
    public class Randomizer
    {
        public List<string> RandomizePowers(List<string> powers)
        {
            List<string> result = new List<string>();

            var shuffledPowersList = Shuffle(powers);
            for (int i = 0; i < 3; i++)
            {
                result.Add(shuffledPowersList[i]);
            }
            SaveToFile(result);
            return result;
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

        public List<string> RandomizePassives(List<string> passives)
        {
            List<string> result = new List<string>();

            var shuffledPassivesList = Shuffle(passives);
            for (int i = 0; i < 3; i++)
            {
                result.Add(shuffledPassivesList[i]);
            }
            SaveToFile(result);
            return result;
        }

        private void SaveToFile(List<string> listToSave)
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            dirPath = Path.Combine(dirPath, "Dishonored 2 Randomizer");
            Directory.CreateDirectory(dirPath);
            var filePath = Path.Combine(dirPath, "Data.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var itemToSave in listToSave)
                {
                    writer.WriteLine(itemToSave);
                }
            }
        }
    }
}
