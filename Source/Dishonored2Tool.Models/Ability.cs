using System.Collections;
using System.Collections.Generic;

namespace Dishonored2Tool
{
    public class Ability : AbilityBase, IEnumerable<IReadOnlyList<AbilityUpgrade>>
    {
        private readonly List<AbilityUpgrade[]> _upgradeChains = new();

        public IReadOnlyList<IReadOnlyList<AbilityUpgrade>> UpgradeChains => _upgradeChains;

        public Ability(string name, int cost, PlayStyle style, Lethality lethality) : base(name, cost, style, lethality) { }

        public void Add(params AbilityUpgrade[] upgradeChain)
        {
            _upgradeChains.Add(upgradeChain);
        }

        public IEnumerator<IReadOnlyList<AbilityUpgrade>> GetEnumerator() => _upgradeChains.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
