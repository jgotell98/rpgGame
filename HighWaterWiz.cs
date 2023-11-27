using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class HighWaterWiz : Enemy
    {
        public HighWaterWiz() : base()
        {
            this.health = 800;
            this.magic = 10000;
            this.maxHealth = 800;
            this.maxMagic = 10000;
            this.power = 5;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new IceBall());
            magicList.Add(new WaterWave());
            magicList.Add(new Whirlpool());
            magicList.Add(new Kick());
            magicList.Add(new Hit());

        }
        override
        public void logic()
        {

            if (this.count <= 0 && magic <= 500)
            {

                magic = maxMagic;
                this.count++;

            }

        }
    }
}
