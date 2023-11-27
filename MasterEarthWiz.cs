using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MasterEarthWiz : Enemy
    {
        public MasterEarthWiz() : base()
        {
            this.health = 4000;
            this.magic = 18000;
            this.maxHealth = 4000;
            this.maxMagic = 18000;
            this.power = 8;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new Boulder());
            magicList.Add(new MudRush());
            magicList.Add(new EarthCoffin());
            magicList.Add(new Earthquake());
            magicList.Add(new EarthSplter());
        }
        override
        public void logic()
        {
            if(this.count <= 0 && health <= 600)
            {
                Console.WriteLine("You'll will pay for that!");
                power++;
            }

        }
    }
}
