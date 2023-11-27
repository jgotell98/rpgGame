using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    public class SmallHealthRecovery : Item
    {
        public SmallHealthRecovery() : base()
        {
            this.name = "smHealth";
            this.heal = true;
            this.mag = false;
            this.price = 2;
            this.weight = 1;

        }
        override
        public void execute(Player player)
        {
            player.health += 10;
            if(player.health > player.maxHealth)
            {
                player.health = player.maxHealth;
            }
            player.dropFormInventory(this);
        }
        
    }
}

