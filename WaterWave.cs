using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class WaterWave : Powers
    {
        public string name { set; get; }
        public int damage { set; get; }
        public int magicDrain { set; get; }
        public ElementType type { get; }


        public WaterWave() : base()
        {
            this.name = "waterwave";
            this.damage = 40;
            this.magicDrain = 25;
            this.type = ElementType.Water;
        }
    }
}
