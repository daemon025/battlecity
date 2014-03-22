namespace BattleCity.Enums
{
    public enum TankType : byte
    {
        FirstUserTank,
        SecondUserTank,

        /* This is the weakest enemy tank. 
         * They move a bit slower than your tank, and their bullets travel at the same speed as yours (with no power-ups applied.) 
         * It takes one shot to destroy them. They generally pose a little threat. Each basic tank scores 100 only. */
        BasicTank,
        /* This is the fastest enemy tank. 
         * They can move at a substantially faster rate than your tank can travel. 
         * Their bullets, however, travel at normal speed. 
         * It takes one shot to destroy them. 
         * These are generally more dangerous to headquarters than a player and should be dispatched quickly. Each fast tank scores 200. */
        FastTank,
        /* This tank has the greatest offensive power. 
         * They move at the speed of normal tanks, but their bullets travel much faster, as fast as your tank can when you collect the star power up. 
         * It takes one shot to destroy them. It's highly advised not to enter into their line of fire. 
         * Although they are generally more dangerous to player, they will cut through bricks much quicker than other tanks 
         *  which is especially clear in level 34. 
         * Each power tank scores 300. */
        PowerTank,
        /* This tank has the most defensive power. They can move and shoot at normal speeds. 
         * However, it takes four shots to destroy them. 
         * They start out green and gradually become gray until the fourth shot destroys them. 
         * It's highly recommended not to destroy tanks with head-on approach before you've collected 2nd star powerup. 
         * Each armor tank scores 400. */
        ArmorTank
    }
}
