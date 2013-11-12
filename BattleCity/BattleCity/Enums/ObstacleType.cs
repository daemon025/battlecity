using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCity.Enums
{
    public enum ObstacleType : byte
    {
        Empty,
        /* Bricks stop tanks and bullets, but they can be slowly chipped away by shooting at them. 
         * A block of bricks the size of the one presented here would take four shots from the same direction to destroy completely (Two when player's tank is upgraded to maximum level). */
        Brick,
        /* Trees allow tanks and bullets to pass through unchecked. 
         * But they partially obscure the view beneath the tree tops making it hard to tell precisely where the enemy tanks are, and even harder to tell where their bullets are. */
        Trees,
        /* Your tank can drive over ice, but it will slide a little bit in the direction that it was traveling in when you let go of 
         *  the D-pad while still standing on the ice. 
         * It also makes projectiles hardly visible. */
        Ice,
        /* Steel walls completely stop tanks and bullets. 
         * Unlike bricks, they can not be destroyed, with the single exception of a player's tank who has collected three stars. */
        Steel,
        /* Tanks cannot traverse water, but bullets can safely fly across. */
        Water,
        Eagle
    }
}
