using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace PowersRandomizer.Tests
{
    [TestClass]
    public class RandomizerTests
    {
        [TestMethod]
        public void RandomizePowersNoDuplicates()
        {
            Randomizer randomizer = new();

            List<string> powers = new List<string>()
            {
                "Bend Time",
                "Devouring Swarm",
                "Possesion",
                "Windblast",
                "Dark Vision",
                "Domino",
                "Doppelg�nger",
                "Mesmerize",
                "Shadow Walk",
            };

            var randomizedList = randomizer.RandomizePowers(powers);
            var distinctList = randomizedList.Distinct().ToList();

            Assert.
        }
    }
}
