using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MedWaterWiz : Enemy
    {
        public MedWaterWiz() : base()
        {
            this.health = 500;
            this.magic = 8000;
            this.maxHealth = 500;
            this.maxMagic = 8000;
            this.power = 4;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new IceBall());
            magicList.Add(new WaterWave());
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
