using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MasterFireWiz : Enemy
    {
        public MasterFireWiz() : base()
        {
            this.health = 15000;
            this.magic = 30000;
            this.maxHealth = 15000;
            this.maxMagic = 30000;
            this.power = 12;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new FireBall());
            magicList.Add(new FireWave());
            magicList.Add(new FireBreath());
            magicList.Add(new FireBlast());
            magicList.Add(new FireStorm());
        }
        override
        public void logic()
        {
            if(this.count <= 0 && health < 5000)
            {
                Console.WriteLine("Now you'll feel the power of the fire");
                power += 3;
            }

        }
    }
}
