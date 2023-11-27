using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class HighFireWiz : Enemy
    {
        public HighFireWiz() : base()
        {
            this.health = 10000;
            this.magic = 25000;
            this.maxHealth = 10000;
            this.maxMagic = 25000;
            this.power = 9;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new FireBall());
            magicList.Add(new FireWave());
            magicList.Add(new FireBreath());

        }
        override
        public void logic()
        {


        }
    }
}
