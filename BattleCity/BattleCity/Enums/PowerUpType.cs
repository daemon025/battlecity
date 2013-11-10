using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCity.Enums
{
    public enum PowerUpType :byte
    {
        // Tank symbol gives an extra life
        TankSymbol,
        // Star improves Tank
        Star,
        // Bomb destroys all visible enemy Tanks
        Bomb,
        // Clock freezes all enemy Tanks for a period of time,
        ClockFreeze,
        // Shovel adds steel walls around the base for a period of time or removes it if picked up by enemy
        Shovel,
        // Shield makes player's Tank invulnerable to attack for a period of time
        Shield
    }
}
