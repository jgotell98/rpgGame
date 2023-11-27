using System.Collections;
using System.Collections.Generic;

namespace StarterGame
{
    public class HelpCommand : Command
    {
        CommandWords words;

        public HelpCommand() : this(new CommandWords())
        {
        }

        public HelpCommand(CommandWords commands) : base()
        {
            words = commands;
            this.name = "help";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot help you with " + this.secondWord);
                if (player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                {
                    return true;
                }
            }
            else
            {
                player.outputMessage("\nYour available commands are " + words.description());
                if (player.currentRoom == GameWorld.Instance.battle || player.currentRoom == GameWorld.Instance.king1 || player.currentRoom == GameWorld.Instance.battle1 || player.currentRoom == GameWorld.Instance.battle2 || player.currentRoom == GameWorld.Instance.battle3 || player.currentRoom == GameWorld.Instance.ew || player.currentRoom == GameWorld.Instance.fw || player.currentRoom == GameWorld.Instance.mw || player.currentRoom == GameWorld.Instance.ww)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
