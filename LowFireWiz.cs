using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LowFireWiz : Enemy
    {
        public LowFireWiz() : base()
        {
            this.health = 4000;
            this.magic = 20000;
            this.maxHealth = 4000;
            this.maxMagic = 20000;
            this.power = 5;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new FireBall());

        }
        override
        public void logic()
        {


        }
    }
}
