namespace Dishonored2Tool.Models
{
    public record PlayOptions(PlayStyle PlayStyle, Lethality Lethality)
    {
        public override string ToString()
        {
            return $"{PlayStyle} - {Lethality}";
        }
    }
}
