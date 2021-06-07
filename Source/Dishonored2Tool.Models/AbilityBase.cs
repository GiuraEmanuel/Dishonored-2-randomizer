namespace Dishonored2Tool
{
    public abstract class AbilityBase
    {
        public string Name { get; }
        public PlayStyle PlayStyle { get; }
        public Lethality Lethality { get; }
        public int Cost { get; }

        protected AbilityBase(string name, int cost, PlayStyle playStyle, Lethality lethality)
        {
            Name = name;
            Cost = cost;
            PlayStyle = playStyle;
            Lethality = lethality;
        }
        public bool SuitableFor(PlayStyle style, Lethality lethality)
        {
            return PlayStyle.HasFlag(style) && Lethality.HasFlag(lethality);
        }
    }
}
