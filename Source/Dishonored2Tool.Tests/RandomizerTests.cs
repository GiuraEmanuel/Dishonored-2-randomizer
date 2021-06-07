using Dishonored2Tool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Dishonored2Tool.Tests
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
                "Doppelgänger",
                "Mesmerize",
                "Shadow Walk",
            };
        }
    }
}
