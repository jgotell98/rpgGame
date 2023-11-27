using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MasterWaterWiz : Enemy
    {
        public MasterWaterWiz() : base()
        {
            this.health = 2500;
            this.magic = 15000;
            this.maxHealth = 2500;
            this.maxMagic = 15000;
            this.power = 5;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new IceBall());
            magicList.Add(new WaterWave());
            magicList.Add(new Whirlpool());
            magicList.Add(new Tsunami());
            magicList.Add(new HighTide());
            magicList.Add(new Kick());
            magicList.Add(new Hit());

        }
        override
        public void logic()
        {

            if (this.count <= 0 && health <= 300)
            {
                Console.WriteLine("I have no choice water rejuvenation");
                health += 800 ;
                magic -= 1000;
                this.count++;

            }

        }
    }
}
