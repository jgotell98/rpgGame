using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class BuyCommand : Command
    {
        public BuyCommand() : base()
        {
            this.name = "buy";

        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                if (player.currentRoom == GameWorld.Instance.store || player.currentRoom == GameWorld.Instance.store1 || player.currentRoom == GameWorld.Instance.store2 || player.currentRoom == GameWorld.Instance.store3) 
                {
                        Item item = player.returnItem(secondWord);
                        GameWorld.Instance.merchant.buy(player, item);
                }
                else
                {
                    player.outputMessage("You're Not in the store");
                    if(player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                    {
                        return true;
                    }
                }

            }
            else
            {
                player.outputMessage("Need second word");
                if (player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
