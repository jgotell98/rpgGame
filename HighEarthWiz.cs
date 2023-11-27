using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class HighEarthWiz : Enemy
    {
        public HighEarthWiz() : base()
        {
            this.health = 2000;
            this.magic = 10000;
            this.maxHealth = 2000;
            this.maxMagic = 10000;
            this.power = 6;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new Boulder());
            magicList.Add(new MudRush());
            magicList.Add(new EarthCoffin());
        }
        override
        public void logic()
        {


        }
    }
}
