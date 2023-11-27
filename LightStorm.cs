using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LightStorm : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public LightStorm() : base()
        {
            this.name = "lightstorm";
            this.damage = 250;
            this.magicDrain = 200;
            this.type = ElementType.Light;
        }
    }
}
