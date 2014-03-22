using BattleCity.Enums;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BattleCity.Models.Tanks
{
    abstract class BaseTank
    {
        #region Properties
        public byte HP { get; set; }
        public int Score { get; set; }
        public byte Speed { get; set; }

        // star improves Tank (having one star make shots faster, having two stars allow two simultaneous shots, having three stars allow to destroy steel)
        public byte Star { get; set; }
        #endregion

        #region Private fields

        Texture2D _tankTexture;
        MoveDirection _moveDirection;
        Bullet[] _bullet = new Bullet[2];
        #endregion

        protected BaseTank(ContentManager contentManager, TankType tankType)
        {   
            InitDirection(tankType);

            LoadContext(contentManager, tankType);
        }

        #region Private Area
        private void LoadContext(ContentManager contentManager, TankType tankType)
        {
            _tankTexture = contentManager.Load<Texture2D>("Textures\\" + tankType.ToString());
        }

        private void InitDirection(TankType tankType)
        {
            if (tankType == TankType.FirstUserTank || tankType == TankType.SecondUserTank)
                _moveDirection = MoveDirection.Up;
            else
                _moveDirection = MoveDirection.Down;
        }
        #endregion

        #region Abstract
        public abstract void Move();
        public abstract void Fire();
        #endregion
    }
}
