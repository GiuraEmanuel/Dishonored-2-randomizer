using System.Collections.Generic;

namespace Dishonored2Tool
{
    public static class AbilitiesData
    {
        public static IReadOnlyList<Ability> Powers { get; } = new List<Ability>()
        {
            new Ability("Bend Time", 5, PlayStyle.Any, Lethality.Any)
            {
                new AbilityUpgrade("Stop Time", 6, PlayStyle.Any, Lethality.Any),
                new AbilityUpgrade("Relativity", 1, PlayStyle.Any, Lethality.Any),
                new AbilityUpgrade("Lasting Bend Time", 2, PlayStyle.Any, Lethality.Any),
            },

            new Ability("Blink", 3, PlayStyle.Any, Lethality.Any)
            {
                new AbilityUpgrade("Greater Blink", 4, PlayStyle.Any, Lethality.Any),
                new AbilityUpgrade("Redirective Blink", 3, PlayStyle.Any, Lethality.Any),
                new AbilityUpgrade("Blink Assault", 1, PlayStyle.Any, Lethality.Lethal),
            },

            new Ability("Dark Vision", 2, PlayStyle.Stealth, Lethality.Any)
            {
                new AbilityUpgrade("Greater Dark Vision", 3, PlayStyle.Stealth, Lethality.Any),
                new AbilityUpgrade("Premonition", 2, PlayStyle.Stealth, Lethality.Any),
            },

            new Ability("Devouring Swarm", 4, PlayStyle.Any, Lethality.Lethal)
            {
                new AbilityUpgrade("Greater Swarm", 2, PlayStyle.Any, Lethality.Lethal),
                new AbilityUpgrade("Rat Piper", 2, PlayStyle.Any, Lethality.Lethal),
                new AbilityUpgrade("Twin Swarms", 3, PlayStyle.Any, Lethality.Lethal),
            },

            new Ability("Possession", 4, PlayStyle.Stealth, Lethality.Any)
            {
                new AbilityUpgrade("Chain Hosts",3,PlayStyle.Stealth,Lethality.Any),
                {
                    new AbilityUpgrade("Corpse Possession",1,PlayStyle.Stealth,Lethality.Any),
                    new AbilityUpgrade("Human Possession",4,PlayStyle.Stealth,Lethality.Any)
                },
                new AbilityUpgrade("Lasting Possession",1,PlayStyle.Stealth,Lethality.Any),
            },

            new Ability("Windblast", 4, PlayStyle.Combat, Lethality.Lethal)
            {
                new AbilityUpgrade("Greater Windblast",3,PlayStyle.Combat,Lethality.Lethal),
                new AbilityUpgrade("Shockwave",3,PlayStyle.Combat,Lethality.Lethal),
            },

            new Ability("Domino", 4, PlayStyle.Any, Lethality.Any)
            {
                {
                    new AbilityUpgrade("Link Three",3,PlayStyle.Any,Lethality.Any),
                    new AbilityUpgrade("Link Four",3,PlayStyle.Any,Lethality.Any)
                },
            },

            new Ability("Doppelgänger", 4, PlayStyle.Any, Lethality.Any)
            {
                new AbilityUpgrade("Baffling Shade",1,PlayStyle.Any,Lethality.Any),
                {
                    new AbilityUpgrade("Deadly Shade",3,PlayStyle.Any,Lethality.Lethal),
                    new AbilityUpgrade("Twin Shades",3,PlayStyle.Any,Lethality.Lethal)
                },
                new AbilityUpgrade("Transposition",2,PlayStyle.Any,Lethality.Any),
            },

            new Ability("Far Reach", 3, PlayStyle.Any, Lethality.Any)
            {
                {
                    new AbilityUpgrade("Pull Objects",2,PlayStyle.Any,Lethality.Any),
                    new AbilityUpgrade("Pull Enemies",4,PlayStyle.Combat,Lethality.Any)
                },
                new AbilityUpgrade("Decelerate",2,PlayStyle.Any,Lethality.Any),
            },

            new Ability("Mesmerize", 6, PlayStyle.Stealth, Lethality.Any)
            {
                {
                    new AbilityUpgrade("Mesmerize Three",3,PlayStyle.Stealth,Lethality.Any),
                    new AbilityUpgrade("Mesmerize Four",3,PlayStyle.Stealth,Lethality.Any)
                },
                new AbilityUpgrade("Lasting Mesmerize",2,PlayStyle.Stealth,Lethality.Any),
            },

            new Ability("Shadow Walk", 4, PlayStyle.Stealth, Lethality.Any)
            {
                new AbilityUpgrade("Rat Shadows",1,PlayStyle.Stealth,Lethality.Any),
                {
                    new AbilityUpgrade("Improved Shadow Attack",2,PlayStyle.Stealth,Lethality.Any),
                    new AbilityUpgrade("Greater Shadow Attack",2,PlayStyle.Stealth,Lethality.Any)
                },
                new AbilityUpgrade("Shadow Run",2,PlayStyle.Stealth,Lethality.Any),
            },
        };

        public static IReadOnlyList<Ability> Passives { get; } = new List<Ability>()
        {
            new Ability("Agility", 2, PlayStyle.Any, Lethality.Any)
            {
                new AbilityUpgrade("Rapid Sprint",2,PlayStyle.Any,Lethality.Any),
                new AbilityUpgrade("Cat Fall",1,PlayStyle.Any,Lethality.Any),
            },

            new Ability("Blood Thirst", 2, PlayStyle.Combat, Lethality.Lethal)
            {
                new AbilityUpgrade("Adrenaline Burst",1,PlayStyle.Combat,Lethality.Lethal),
                new AbilityUpgrade("Greater Blood Thirst",3,PlayStyle.Combat,Lethality.Lethal),
            },

            new Ability("Bonecharm Crafting", 1, PlayStyle.Any, Lethality.Any)
            {
                {
                    new AbilityUpgrade("Witch Crafting",2,PlayStyle.Any,Lethality.Any),
                    new AbilityUpgrade("Master Crafting",2,PlayStyle.Any,Lethality.Any),
                    new AbilityUpgrade("Craft Runes",4,PlayStyle.Any,Lethality.Any)
                },
                new AbilityUpgrade("Trait Synergy",3,PlayStyle.Any,Lethality.Any),
            },

            new Ability("Reflexes", 1, PlayStyle.Combat, Lethality.Any)
            {
                new AbilityUpgrade("Focused Slide",2,PlayStyle.Combat,Lethality.Any),
                new AbilityUpgrade("Superior Deflection",2,PlayStyle.Combat,Lethality.Lethal),
                new AbilityUpgrade("Adept Parry",1,PlayStyle.Combat,Lethality.Any),
                new AbilityUpgrade("Snap Reaction",3,PlayStyle.Combat,Lethality.Any),
            },

            new Ability("Shadow Kill", 2, PlayStyle.Any, Lethality.Lethal)
            {
                {
                    new AbilityUpgrade("Greater Shadow Kill",2,PlayStyle.Any,Lethality.Lethal),
                    new AbilityUpgrade("Bloodfly Swarm",3,PlayStyle.Combat,Lethality.Lethal)
                },
            },

            new Ability("Strength", 3, PlayStyle.Any, Lethality.NonLethal)
            {
                new AbilityUpgrade("Greater Strength",2,PlayStyle.Combat,Lethality.NonLethal),
            },

            new Ability("Vitality", 2, PlayStyle.Combat, Lethality.Any)
            {
                new AbilityUpgrade("Greater Vitality",2,PlayStyle.Combat,Lethality.Any),
            },
        };
    }
}
