using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class CastCommand : Command
    {
        public CastCommand() : base()
        {
            this.name = "cast";

        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                if (player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                {
                    if (player.FindPower(secondWord) == true)
                    {
                        Powers powers = player.returnPower(secondWord);
                        if (player.magic >= powers.magicDrain)
                        {
                            Console.WriteLine(secondWord + " is use");
                            player.magic -= powers.magicDrain;
                           
                        }
                        else
                        {
                            player.outputMessage("Magic is too low!");
                            return true;
                        }
                    }
                    else
                    {
                        player.outputMessage("Magic is not learn");
                        return true;
                    }
                }
                else
                {
                    player.outputMessage("Not in battle");
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
