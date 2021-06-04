using System;

namespace PowersRandomizer
{
    [Flags]
    public enum Lethality
    {
        Lethal = 1,
        NonLethal = 2,
        Any = Lethal | NonLethal,
    }
    [Flags]
    public enum Style
    {
        Combat = 1,
        Stealth = 2,
        Any = Combat | Stealth,
    }

    public abstract class AbilityBase
    {
        public string Name { get; }
        public Style Style { get; }
        public Lethality Lethality { get; }
        public int Cost { get; }

        protected AbilityBase(string name, int cost, Style combat, Lethality lethal)
        {
            Name = name;
            Cost = cost;
            Style = combat;
            Lethality = lethal;
        }
    }
}
