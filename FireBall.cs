using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class FireBall : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public FireBall() : base()
        {
            this.name = "fireball";
            this.damage = 50;
            this.magicDrain = 10;
            this.type = ElementType.Fire;
        }
    }
}
