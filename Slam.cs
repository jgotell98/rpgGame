using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Slam : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public Slam() : base()
        {
            this.name = "slam";
            this.damage = 15;
            this.magicDrain = 0;
            this.type = ElementType.Physical;
        }
    }
}
