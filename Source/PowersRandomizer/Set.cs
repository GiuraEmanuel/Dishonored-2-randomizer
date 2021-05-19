using System;
using System.Collections.Generic;

namespace PowersRandomizer
{
    public class Set
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<string> Powers { get; set; } = new();
        public List<string> Passives { get; set; } = new();
    }
}
