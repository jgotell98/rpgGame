using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Earthquake : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public Earthquake() : base()
        {
            this.name = "earthquake";
            this.damage = 80;
            this.magicDrain = 45;
            this.type = ElementType.Earth;
        }
    }
}
