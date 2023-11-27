using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LargeHealthRecovery : Item
    {
        public LargeHealthRecovery() : base()
        {
            this.name = "lgHealth";
            this.heal = true;
            this.mag = false;
            this.price = 5;
            this.weight = 4;

        }
        override
        public void execute(Player player)
        {
            player.health += 25;
            if (player.health > player.maxHealth)
            {
                player.health = player.maxHealth;
            }
            player.dropFormInventory(this);
        }
    }
}
