using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame
{
    public abstract class GameObject
    {
        public string name;
        public Game1 game
        {
            get
            {
                return Game1.Instance;
            }
        }
        public virtual void OnInit()
        {
            name = "~~~";
        }
        public virtual void OnUpdate(GameTime gameTime)
        {

        }
        public virtual void OnDraw(GameTime gameTime)
        {

        }
    }
}
