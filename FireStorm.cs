using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class FireStorm : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public FireStorm() : base()
        {
            this.name = "firestorm";
            this.damage = 200;
            this.magicDrain = 150;
            this.type = ElementType.Fire;
        }
    }
}
