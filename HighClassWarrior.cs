using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class HighClassWarrior : Enemy
    {
        public HighClassWarrior() : base()
        {
            this.health = 250;
            this.magic = 0;
            this.maxHealth = 250;
            this.maxMagic = 0;
            this.power = 5;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());

        }
        override
        public void logic()
        {
            
            if (count <= 4 && health < 40)
            {
                Console.WriteLine("Enemy use lgHealth");
                health += 25;
                count++;
            }

        }
    }
}
