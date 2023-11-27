using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class EarthSplter : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public EarthSplter() : base()
        {
            this.name = "earthsplter";
            this.damage = 150;
            this.magicDrain = 100;
            this.type = ElementType.Physical;
        }
    }
}
