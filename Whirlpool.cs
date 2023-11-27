using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Whirlpool : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public Whirlpool() : base()
        {
            this.name = "whirlpool";
            this.damage = 60;
            this.magicDrain = 50;
            this.type = ElementType.Water;
        }
    }
}
