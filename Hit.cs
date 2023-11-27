using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Hit : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }
        

        public Hit() : base()
        {
            this.name = "hit";
            this.damage = 1;
            this.magicDrain = 0;
            this.type = ElementType.Physical;
        }
    }
}
