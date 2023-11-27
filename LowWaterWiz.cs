using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LowWaterWiz : Enemy
    {
        public LowWaterWiz() : base()
        {
            this.health = 300;
            this.magic = 6000;
            this.maxHealth = 300;
            this.maxMagic = 6000;
            this.power = 3;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new IceBall());
            magicList.Add(new Kick());
            magicList.Add(new Hit());

        }
        override
        public void logic()
        {

            if (this.count <= 0 && magic <= 100)
            {
                
                magic = maxMagic;
                this.count++;

            }

        }
    }
}
