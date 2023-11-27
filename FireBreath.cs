using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class FireBreath : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public FireBreath() : base()
        {
            this.name = "firebreath";
            this.damage = 120;
            this.magicDrain = 50;
            this.type = ElementType.Fire;
        }
    }
}
