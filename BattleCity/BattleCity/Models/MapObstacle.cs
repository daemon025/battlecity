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
    public class MapObstacle
    {
        private Texture2D texture;
        private Rectangle drawRectangle;
        private MapObject objectIdentity;

        public MapObstacle(ContentManager contentManager, Rectangle drawRectangle, MapObject mapObject)
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
            string textureName;

            switch (objectIdentity)
            {
                case MapObject.Brick:
                    textureName = "Brick";
                    break;
                case MapObject.Eagle:
                    textureName = "Eagle";
                    break;
                case MapObject.Grass:
                    textureName = "Forest";
                    break;
                case MapObject.Ice:
                    textureName = "Ice";
                    break;
                case MapObject.Steel:
                    textureName = "Steel";
                    break;
                case MapObject.Water:
                    textureName = "Water";
                    break;
                default:
                    textureName = "Missing";
                    break;
            }

            texture = contentManager.Load<Texture2D>("Textures\\"+textureName);
        }
    }
}
