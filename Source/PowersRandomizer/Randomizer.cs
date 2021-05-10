using System;
using System.Collections.Generic;

namespace PowersRandomizer
{
    public class Randomizer
    {
        public List<string> RandomizePowers(List<string> powers)
        {
            List<string> result = new List<string>();

            var shuffledPowerList = Shuffle(powers);
            for (int i = 0; i < 3; i++)
            {
                result.Add(shuffledPowerList[i]);
            }
            return result;
        }

        private List<string> Shuffle(List<string> listToShuffle)
        {
            Random r = new Random();
            //copy to shuffledList

            List<string> shuffledList = new List<string>(listToShuffle);
            //shuffle shuffledList 
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
            return result;
        }
    }
}
