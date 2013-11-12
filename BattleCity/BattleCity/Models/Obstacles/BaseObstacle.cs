using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using BattleCity.Enums;

namespace BattleCity.Models
{
    public class BaseObstacle
    {
        private Texture2D texture;
        private Rectangle drawRectangle;
        private ObstacleType objectIdentity;

        public BaseObstacle(ContentManager contentManager, Rectangle drawRectangle, ObstacleType mapObject)
        {
            this.drawRectangle = drawRectangle;
            this.objectIdentity = mapObject;

            LoadContent(contentManager);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, drawRectangle, Color.AliceBlue);
        }

        private void LoadContent(ContentManager contentManager)
        {
            texture = contentManager.Load<Texture2D>("Textures\\"+objectIdentity.ToString());
        }
    }
}
