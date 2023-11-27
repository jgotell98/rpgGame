using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class LargeMagicRecovery : Item
    {
        public LargeMagicRecovery() : base()
        {
            this.name = "lgMagic";
            this.heal = false;
            this.mag = true;
            this.price = 10;
            this.weight = 1;

        }
        override
        public void execute(Player player)
        {
            player.magic += 25;
            if (player.magic > player.maxMagic)
            {
                player.magic = player.maxMagic;
            }
            player.dropFormInventory(this);
        }
    }
}
