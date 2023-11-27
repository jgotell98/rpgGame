using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LowEarthWiz : Enemy
    {
        public LowEarthWiz() : base()
        {
            this.health = 1000;
            this.magic = 6000;
            this.maxHealth = 1000;
            this.maxMagic = 6000;
            this.power = 4;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new Boulder());
        }
        override
        public void logic()
        {


        }
    }
}

