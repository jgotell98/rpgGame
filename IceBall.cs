using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class IceBall : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public IceBall() : base()
        {
            this.name = "iceball";
            this.damage = 20;
            this.magicDrain = 10;
            this.type = ElementType.Water;
        }
    }
}
