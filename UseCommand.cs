using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class UseCommand : Command
    {
       
        public UseCommand() : base()
        {
            this.name = "use";
       
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
               if(player.FindInventory(secondWord) == true)
                {
                    Item item = player.returnItem(secondWord);
                    item.execute(player);
                    if (player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                    {
                        return true;
                    }
                }
                else
                {
                    player.outputMessage("Not in the inventory");
                    if (player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                    {
                        return true;
                    }
                }
                
                
            }
            else
            {
                player.outputMessage("Need second word");
            }
            return false;
        }
        
        
    }
}
