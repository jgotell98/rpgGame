using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class EarthCoffin : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public EarthCoffin() : base()
        {
            this.name = "earthcoffin";
            this.damage = 110;
            this.magicDrain = 65;
            this.type = ElementType.Earth;
        }
    }
}
