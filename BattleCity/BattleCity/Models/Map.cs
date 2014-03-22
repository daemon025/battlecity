using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleCity.Models.Obstacles;
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
        IList<BaseObstacle> mapObstacles;
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
            ObstacleType[,] obstacles = {
                                            { ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Steel, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Steel, ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty },
                                            { ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Steel, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Empty },
                                            { ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Water, ObstacleType.Water, ObstacleType.Water, ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Steel,ObstacleType.Brick,ObstacleType.Empty },
                                            { ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty,ObstacleType.Steel,ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty },
                                            { ObstacleType.Trees, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Steel, ObstacleType.Empty, ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Trees,ObstacleType.Brick,ObstacleType.Steel },
                                            { ObstacleType.Trees, ObstacleType.Trees, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Steel,ObstacleType.Empty,ObstacleType.Trees,ObstacleType.Empty,ObstacleType.Empty },
                                            { ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Trees, ObstacleType.Trees, ObstacleType.Trees, ObstacleType.Steel, ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Trees,ObstacleType.Brick,ObstacleType.Empty },
                                            { ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Steel, ObstacleType.Trees, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Empty },
                                            { ObstacleType.Steel, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Steel, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Empty },
                                            { ObstacleType.Ice, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Steel,ObstacleType.Brick,ObstacleType.Empty },
                                            { ObstacleType.Ice, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty,ObstacleType.Empty },
                                            { ObstacleType.Ice, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Brick, ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Empty },
                                            { ObstacleType.Ice, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Empty, ObstacleType.Brick, ObstacleType.Eagle, ObstacleType.Brick, ObstacleType.Empty,ObstacleType.Brick,ObstacleType.Brick,ObstacleType.Brick,ObstacleType.Empty }
                                        };


            mapObstacles = new List<BaseObstacle>();

            int x = drawRectangle.X;
            int y = drawRectangle.Y;

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if(obstacles[i,j] != ObstacleType.Empty)
                        mapObstacles.Add(new BaseObstacle(contentManager,
                            new Rectangle(x, y, 32,32),
                            obstacles[i, j]));

                    x += 32;
                }

                y += 32;
                x = drawRectangle.X;
            }

        }
        #endregion
    }
}
