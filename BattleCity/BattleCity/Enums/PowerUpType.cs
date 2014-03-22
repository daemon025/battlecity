namespace BattleCity.Enums
{
    /* Powerups will disappear when another flashing tank starts to appear.
       The 4th, 11th and 18th tanks in the level are flashing ones. */
    public enum PowerUpType : byte
    {
        /* The tank power up grants you one extra life. The only other way to get an extra life is to score 20000 points. */
        Tank,
        /* The star power up grants your tank with new offensive power each time you pick one up, up to three times. 
         * The first star allows you to fire your bullets as fast as the power tanks can. 
         * The second star allows you to fire up to two bullets on the screen at one time. 
         * And the third star allows your bullets to destroy the otherwise unbreakable steel walls and also destroys 
         *  two layers of bricks at once instead of one. You carry this power with you to each new stage until you lose a life. */
        Star,
        /* Picking up the grenade power up instantly wipes out ever enemy presently on the screen, 
         * including Armor Tanks regardless of how many times you've hit them. 
         * You do not, however, get credit for destroying them during the end-stage bonus points.*/
        Grenade,
        /* The timer power up temporarily freezes time, 
         *  allowing you to harmlessly approach every tank and destroy them until the time freeze wears off. */
        Timer,
        /* The shovel power up turns the walls around your fortress from brick to stone. 
         * This makes it impossible for the enemy to penetrate the wall and destroy your fortress, ending the game prematurely. The effect, however, is only temporary, and will wear off eventually. In addition of adding steel blocks, it also repairs the damage previously done to the wall. */
        Shovel,
        /* The helmet power up grants you a temporary force field that makes you invulnerable to enemy shots, 
         * just like the one you begin every stage with. */
        Helmet
    }
}
