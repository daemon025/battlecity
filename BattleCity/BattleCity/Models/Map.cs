using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using BattleCity.Enums;

namespace BattleCity.Models
{
    public class Map
    {
        #region Map attributes
        Rectangle drawRectangle;
        Texture2D background;
        IList<MapObstacle> mapObstacles;
        #endregion

        public Map(ContentManager contentManager, Rectangle drawRectangle)
        {
            this.drawRectangle = drawRectangle;

            this.LoadContext(contentManager);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, drawRectangle, Color.Black);

            foreach (var obstacle in mapObstacles)
                obstacle.Draw(spriteBatch);
        }

        #region Private area
        private void LoadContext(ContentManager contentManager)
        {
            background = contentManager.Load<Texture2D>("Textures\\Black-Background");
            LoadLevel(contentManager, 1);
        }

        private void LoadLevel(ContentManager contentManager, int level)
        {
            //TODO: implement it
            Random rand = new Random();
            mapObstacles = new List<MapObstacle>();

            int x = drawRectangle.X;
            int y = drawRectangle.Y;

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    MapObject obj = (MapObject)rand.Next(6) + 1;

                    mapObstacles.Add(new MapObstacle(contentManager,
                        new Rectangle(x, y, 32,32),
                        obj));

                    y += 32;
                }

                x += 32;
                y = drawRectangle.Y;
            }

        }
        #endregion
    }
}
