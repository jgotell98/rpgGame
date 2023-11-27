using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Kick : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public Kick() : base()
        {
            this.name = "kick";
            this.damage = 5;
            this.magicDrain = 0;
            this.type = ElementType.Physical;
        }
    }
}
