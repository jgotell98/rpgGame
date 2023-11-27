using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class WarriorKing : Enemy
    {
        public WarriorKing() : base()
        {
            this.health = 101;
            this.magic = 0;
            this.maxHealth = 1000;
            this.maxMagic = 0;
            this.power = 5;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
            magicList.Add(new Slam());
            
        }
        override
        public void logic()
        {
            
            if (this.count <= 0 && health <= 100)
            {
                Console.WriteLine("Now you make me mad!");
                Console.WriteLine("Warrior king has become stronger!");
                health += 100;
                power += 3;
                this.count++;

            }

        }
    }
}
