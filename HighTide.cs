using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class HighTide : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public HighTide() : base()
        {
            this.name = "hightide";
            this.damage = 100;
            this.magicDrain = 100;
            this.type = ElementType.Water;
        }
    }
}
