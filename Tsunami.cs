using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Tsunami : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public Tsunami() : base()
        {
            this.name = "tsunami";
            this.damage = 250;
            this.magicDrain = 150;
            this.type = ElementType.Water;
        }
    }
}
