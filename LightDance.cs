using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LightDance : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public LightDance() : base()
        {
            this.name = "lightdance";
            this.damage = 150;
            this.magicDrain = 110;
            this.type = ElementType.Light;
        }
    }
}
