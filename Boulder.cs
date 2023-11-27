using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Boulder : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public Boulder() : base()
        {
            this.name = "boulder";
            this.damage = 35;
            this.magicDrain = 25;
            this.type = ElementType.Earth;
        }
    }
}
