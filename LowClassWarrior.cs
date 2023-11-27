using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LowClassWarrior : Enemy
    {
        public LowClassWarrior() : base()
        {
            this.health = 50;
            this.magic = 0;
            this.maxHealth = 50;
            this.maxMagic = 0;
            this.power = 1;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            
        }
        override
        public void logic()
        {
           

        }
    }
}
