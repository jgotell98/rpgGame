using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LightBall : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public LightBall() : base()
        {
            this.name = "lightball";
            this.damage = 100;
            this.magicDrain = 90;
            this.type = ElementType.Light;
        }
    }
}
