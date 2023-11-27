using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class MedClassWarrior : Enemy
    {
        public MedClassWarrior() : base()
        {
            this.health = 75;
            this.magic = 0;
            this.maxHealth = 75;
            this.maxMagic = 0;
            this.power = 3;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());

        }
        override
        public void logic()
        {
            
            if(count <= 2 && health < 10)
            {
                Console.WriteLine("Enemy use lgHealth");
                health += 25;
                count++;
            }

        }
    }
}
