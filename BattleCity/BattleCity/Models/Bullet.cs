using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using BattleCity.Enums;

namespace BattleCity.Models
{
    public class Bullet
    {
        public byte Damage { get; set; }
        public bool IsActive { get; set; }

        private Texture2D texture;
        private Rectangle drawRectangle { get; set; }
        private MoveDirection moveDirection { get; set; }
        private float Speed { get; set; }

        public Bullet(Texture2D texture, int x, int y, MoveDirection moveDirection)
        {
            Damage = 1;
            this.texture = texture;
            this.moveDirection = moveDirection;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, drawRectangle, Color.AliceBlue);
        }
    }
}
