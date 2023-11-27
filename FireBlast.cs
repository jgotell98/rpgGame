using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class FireBlast : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public FireBlast() : base()
        {
            this.name = "fireblast";
            this.damage = 150;
            this.magicDrain = 75;
            this.type = ElementType.Fire;
        }
    }
}
