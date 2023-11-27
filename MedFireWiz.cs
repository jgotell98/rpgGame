using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MedFireWiz : Enemy
    {
        public MedFireWiz() : base()
        {
            this.health = 6000;
            this.magic = 22000;
            this.maxHealth = 6000;
            this.maxMagic = 22000;
            this.power = 7;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new FireBall());
            magicList.Add(new FireWave());

        }
        override
        public void logic()
        {


        }
    }
}
