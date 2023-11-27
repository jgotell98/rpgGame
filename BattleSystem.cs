using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace StarterGame
{
    class BattleSystem
    {
        Random rnd = new Random();
        private bool _playIsDef; //Return true if the player health is 0
        private bool _emIsDef; // Return true if the enemy health is 0
        private Parser Parser; // This parser is only use for the battle system
        public bool playIsDef
        {
            get
            {
                return _playIsDef;
            }
            set
            {
                _playIsDef = value;
            }
        }
        public bool emIsDef
        {
            get
            {
                return _emIsDef;
            }
            set
            {
                _emIsDef = value;
            }
        }
        public BattleSystem()
        {
            Parser = new Parser(new CommandWords());
        }
        
        public void battle(Player player, Enemy enemy)
        {
   
            
            while(!playIsDef && !emIsDef)
            {
                bool playerTurn = true;
                bool enemyTurn = false;
                while(playerTurn == true)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("It's Your turn.");
                    Console.WriteLine(player.battlestats());
                    Command command = Parser.parseCommand(Console.ReadLine());

                    if (command.execute(player) == false)
                    {
                        
                        Powers powers = player.returnPower(command.secondWord);
                        enemy.health -= powers.damage * player.power;
                        Console.WriteLine(powers.damage * player.power + " Damage!");
                        if(enemy.health <= 0)
                        {
                            Console.WriteLine("Enemy is down, You won");                          
                            emIsDef = true;
                            if(player.currentRoom == GameWorld.Instance.battle)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance;
                            }
                            if (player.currentRoom == GameWorld.Instance.battle1)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance1;
                            }
                            if (player.currentRoom == GameWorld.Instance.battle2)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance2;
                            }
                            if (player.currentRoom == GameWorld.Instance.battle3)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance3;
                            }
                            if (player.currentRoom == GameWorld.Instance.king1)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance;
                            }
                            if (player.currentRoom == GameWorld.Instance.ww)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance1;
                            }
                            if (player.currentRoom == GameWorld.Instance.ew)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance2;
                            }
                            if (player.currentRoom == GameWorld.Instance.fw)
                            {
                                player.currentRoom = GameWorld.Instance.Entrance3;
                            }
                            break;
                            
                        }
                        enemyTurn = true;
                        playerTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Not Working");
                    }
                    
                }
                while(enemyTurn == true) 
                {
                    Console.WriteLine(" ");
                    enemy.logic();
                    Console.WriteLine(" ");
                    Console.WriteLine("Enemy's Health: " + enemy.health + "/" + enemy.maxHealth + " Enemy's Magic: " + enemy.magic + "/" + enemy.maxMagic);
                    Random rand = new Random();
                    int an = rand.Next(enemy.magicList.Count);
                    Powers powers = enemy.returnPowers(an);
                    Console.WriteLine(powers.name + " is use");
                    enemy.magic -= powers.magicDrain;
                    player.health -= powers.damage * enemy.power;
                    Console.WriteLine(powers.damage * enemy.power + " Damage!");
                                       
                    if (player.health <= 0)
                    {
                        Console.WriteLine("You Lost");
                        playIsDef = true;
                        System.Environment.Exit(0);
                        break;
                    }
                    playerTurn = true;
                    enemyTurn = false;

                }


            }

        }
    }
}
