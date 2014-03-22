using BattleCity.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleCity.Models.Obstacles
{
    public class BaseObstacle
    {
        private Texture2D _texture;
        private readonly Rectangle _drawRectangle;
        private readonly ObstacleType _objectIdentity;

        public BaseObstacle(ContentManager contentManager, Rectangle drawRectangle, ObstacleType mapObject)
        {
            _drawRectangle = drawRectangle;
            _objectIdentity = mapObject;

            LoadContent(contentManager);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _drawRectangle, Color.AliceBlue);
        }

        private void LoadContent(ContentManager contentManager)
        {
            _texture = contentManager.Load<Texture2D>("Textures\\"+_objectIdentity.ToString());
        }
    }
}
