using System;

namespace Dishonored2Tool
{
    [Flags]
    public enum PlayStyle
    {
        Combat = 1,
        Stealth = 2,
        Any = Combat | Stealth,
    }
}
