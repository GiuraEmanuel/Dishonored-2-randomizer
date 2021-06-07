using System;

namespace Dishonored2Tool
{
    [Flags]
    public enum Lethality
    {
        Lethal = 1,
        NonLethal = 2,
        Any = Lethal | NonLethal,
    }
}
