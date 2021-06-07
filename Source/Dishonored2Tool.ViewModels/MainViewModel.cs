using Dishonored2Tool.Models;
using System.Collections.Generic;

namespace Dishonored2Tool.ViewModels
{
    public class MainViewModel
    {
        private PlayOptions selectedPlayOptons;

        public IReadOnlyList<PlayOptions> PlayOptions { get; } = new List<PlayOptions>()
        {
            new PlayOptions(PlayStyle.Stealth,Lethality.Lethal),
            new PlayOptions(PlayStyle.Stealth,Lethality.NonLethal),
            new PlayOptions(PlayStyle.Combat,Lethality.Lethal),
            new PlayOptions(PlayStyle.Combat,Lethality.NonLethal)
        };



        public PlayOptions SelectedPlayOptons
        {
            get => selectedPlayOptons;
            set => selectedPlayOptons = value;
        }

    }
}
