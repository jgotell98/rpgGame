using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MidEarthWiz : Enemy
    {
        public MidEarthWiz() : base()
        {
            this.health = 1600;
            this.magic = 8000;
            this.maxHealth = 1600;
            this.maxMagic = 8000;
            this.power = 5;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new Boulder());
            magicList.Add(new MudRush());
        }
        override
        public void logic()
        {


        }
    }
}

