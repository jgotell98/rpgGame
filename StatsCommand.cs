using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class StatsCommand : Command
    {
        public StatsCommand() : base()
        {
            
            this.name = "stats";
        }

        override
        public bool execute(Player player)
        {

            if (this.hasSecondWord())
            {
                player.outputMessage("Don't need second word");
                
            }
            else
            {
                if(player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                {
                    Console.WriteLine("You're in battle");
                    return true;
                }
                player.outputMessage(player.stats());
                
            }

            return false;
        }
    }
}

