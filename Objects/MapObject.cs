using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame.Objects
{
    [Serializable]
    public class MapObject : GameObject
    {
        public override void OnInit()
        {
            base.OnInit();
            name = "Map";


        }
        public override void OnUpdate(GameTime gameTime)
        {
            base.OnUpdate(gameTime);
        }
    }
}
