using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MudRush : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public MudRush() : base()
        {
            this.name = "mudrush";
            this.damage = 60;
            this.magicDrain = 35;
            this.type = ElementType.Earth;
        }
    }
}
