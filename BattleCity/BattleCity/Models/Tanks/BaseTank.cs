using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using BattleCity.Enums;
using Microsoft.Xna.Framework.Graphics;

namespace BattleCity.Models
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
        Texture2D tankTexture;
        MoveDirection moveDirection;
        Bullet[] bullet = new Bullet[2];
        #endregion

        public BaseTank(ContentManager contentManager, TankType tankType)
        {   
            InitDirection(tankType);

            LoadContext(contentManager, tankType);
        }

        #region Private Area
        private void LoadContext(ContentManager contentManager, TankType tankType)
        {
            tankTexture = contentManager.Load<Texture2D>("Textures\\" + tankType.ToString());
        }

        private void InitDirection(TankType tankType)
        {
            if (tankType == TankType.FirstUserTank || tankType == TankType.SecondUserTank)
                moveDirection = MoveDirection.Up;
            else
                moveDirection = MoveDirection.Down;
        }
        #endregion

        #region Abstract
        public abstract void Move();
        public abstract void Fire();
        #endregion
    }
}
