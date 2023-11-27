using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class SmallMagicRecovery : Item
    {
        public SmallMagicRecovery() : base()
        {
            this.name = "smMagic";
            this.heal = false;
            this.mag = true;
            this.price = 6;
            this.weight = 1;

        }
        override
        public void execute(Player player)
        {
            player.magic += 10;
            if (player.magic > player.maxMagic)
            {
                player.magic = player.maxMagic;
            }
            player.dropFormInventory(this);
        }
    }
}
