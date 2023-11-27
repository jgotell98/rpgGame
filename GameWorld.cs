using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class GameWorld
    {
        private static GameWorld _instance = null;
        public static GameWorld Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameWorld();
                }
                return _instance;
            }
        }

        private Room _entrance;
        public Room Entrance
        {
            get
            {
                return _entrance;
            }
        }

        private Room _entrance1;
        public Room Entrance1
        {
            get
            {
                return _entrance1;
            }
        }

        private Room _entrance2;
        public Room Entrance2
        {
            get
            {
                return _entrance2;
            }
        }

        private Room _entrance3;
        public Room Entrance3
        {
            get
            {
                return _entrance3;
            }
        }

        private Room _store;
        public Room store
        {
            get
            {
                return _store;
            }
        }
        private Room _store1;
        public Room store1
        {
            get
            {
                return _store1;
            }
        }
        private Room _store2;
        public Room store2
        {
            get
            {
                return _store2;
            }
        }
        private Room _store3;
        public Room store3
        {
            get
            {
                return _store3;
            }
        }
        private Room _battle;
        public Room battle
        {
            get
            {
                return _battle;
            }
        }

        private Room _battle1;
        public Room battle1
        {
            get
            {
                return _battle1;
            }
        }

        private Room _battle2;
        public Room battle2
        {
            get
            {
                return _battle2;
            }
        }

        private Room _battle3;
        public Room battle3
        {
            get
            {
                return _battle3;
            }
        }
        private Room _medi;
        public Room medi
        {
            get
            {
                return _medi;
            }
        }
        private Room _medi1;
        public Room medi1
        {
            get
            {
                return _medi1;
            }
        }
        private Room _medi2;
        public Room medi2
        {
            get
            {
                return _medi2;
            }
        }
        private Room _medi3;
        public Room medi3
        {
            get
            {
                return _medi3;
            }
        }
        private Room _forrest;
        public Room forrest
        {
            get
            {
                return _forrest;
            }
        }

        private Room _ww;
        public Room ww
        {
            get
            {
                return _ww;
            }
        }

        private Room _ew;
        public Room ew
        {
            get
            {
                return _ew;
            }
        }

        private Room _fw;
        public Room fw
        {
            get
            {
                return _fw;
            }
        }

        private Room _mw;
        public Room mw
        {
            get
            {
                return _mw;
            }
        }

        private Room _tr;
        public Room tr
        {
            get
            {
                return _tr;
            }
        }

        private Merchant _merchant = new Merchant();
        public Merchant merchant
        {
            get
            {
                return _merchant;
            }
        }
        private Trainer _trainer = new Trainer();
        public Trainer trainer
        {
            get
            {
                return _trainer;
            }
        }
        private Room _king1;
        public Room king1
        {
            get
            {
                return _king1;
            }
        }

        

        private bool _warriorKingDow = false;
        public bool warriorKingDow
        {
            set { _warriorKingDow = value; }
            get { return _warriorKingDow; }
        }

        private bool _WizDow1 = false;
        public bool WizDow1
        {
            set { _WizDow1 = value; }
            get { return _WizDow1; }
        }

        private bool _WizDow2 = false;
        public bool WizDow2
        {
            set { _WizDow2 = value; }
            get { return _WizDow2; }
        }

        private bool _WizDow3 = false;
        public bool WizDow3
        {
            set { _WizDow3 = value; }
            get { return _WizDow3; }
        }

        private bool _WizDow4 = false;
        public bool WizDow4
        {
            set { _WizDow4 = value; }
            get { return _WizDow4; }
        }


        private GameWorld()
        {
            createWorld();
            NotificationCenter.Instance.addObserver("PlayerDidEnterRoom", playerDidEnterRoom);
        }
        private void createWorld()
        {
            Room outside = new Room("outside");
            Room tradeStore = new Room("in the trade store");
            Room battleArena = new Room("in the battle arena");
            Room medicalCenter = new Room("in the medical Center");
            Room warriorKing = new Room("in the Warrior King's castle");
            Room forrest = new Room("in the Forrest");
            Room outside1 = new Room("outside in the world of water");
            Room tradeStore1 = new Room("in the trade store");
            Room battleArena1 = new Room("in the battle arena");
            Room medicalCenter1 = new Room("in the medical Center");
            Room waterMasterWiz = new Room("");
            Room outside2 = new Room("outside in the world of earth");
            Room tradeStore2 = new Room("in the trade store");
            Room battleArena2 = new Room("in the battle arena");
            Room medicalCenter2 = new Room("in the trade store");
            Room earthMasterWiz = new Room("");
            Room outside3 = new Room("outside in the world of fire");
            Room tradeStore3 = new Room("in the trade store");
            Room battleArena3 = new Room("in the battle arena");
            Room medicalCenter3 = new Room("in the medical Center");
            Room fireMasterWiz = new Room("");
            Room grandMasterWiz = new Room("");
            Room training = new Room("in the training area");

            outside.setExit("store", tradeStore);
            outside.setExit("battle", battleArena);
            outside.setExit("medical", medicalCenter);
            outside.setExit("king", warriorKing);
           

            tradeStore.setExit("outside", outside);
            battleArena.setExit("outside", outside);
            medicalCenter.setExit("outside", outside);
            warriorKing.setExit("outside", outside);

            forrest.setExit("warrior", outside);
            forrest.setExit("water", outside1);
            forrest.setExit("train", training);

            outside1.setExit("store", tradeStore1);
            outside1.setExit("battle", battleArena1);
            outside1.setExit("medical", medicalCenter1);
            outside1.setExit("wiz", waterMasterWiz);
            outside1.setExit("forrest", forrest);

            tradeStore1.setExit("outside", outside1);
            battleArena1.setExit("outside", outside1);
            medicalCenter1.setExit("outside", outside1);
            waterMasterWiz.setExit("outside", outside1);

            outside2.setExit("store", tradeStore2);
            outside2.setExit("battle", battleArena2);
            outside2.setExit("medical", medicalCenter2);
            outside2.setExit("wiz", earthMasterWiz);
            outside2.setExit("forrest", forrest);

            tradeStore2.setExit("outside", outside2);
            battleArena2.setExit("outside", outside2);
            medicalCenter2.setExit("outside", outside2);
            earthMasterWiz.setExit("outside", outside2);

            outside3.setExit("store", tradeStore3);
            outside3.setExit("battle", battleArena3);
            outside3.setExit("medical", medicalCenter3);
            outside3.setExit("wiz", fireMasterWiz);
            outside3.setExit("forrest", forrest);

            tradeStore3.setExit("outside", outside3);
            battleArena3.setExit("outside", outside3);
            medicalCenter3.setExit("outside", outside3);
            fireMasterWiz.setExit("outside", outside3);

            grandMasterWiz.setExit("forrest", forrest);

            training.setExit("forrest", forrest);



            _entrance = outside;

            _entrance1 = outside1;

            _entrance2 = outside2;

            _entrance3 = outside3;

            _store = tradeStore;

            _store1 = tradeStore1;

            _store2 = tradeStore2;

            _store3 = tradeStore3;

            _battle = battleArena;

            _medi = medicalCenter;

            _medi1 = medicalCenter1;

            _medi2 = medicalCenter2;

            _medi3 = medicalCenter3;

            _king1 = warriorKing;

            _forrest = forrest;

            _ww = waterMasterWiz;

            _ew = earthMasterWiz;

            _fw = fireMasterWiz;

            _mw = grandMasterWiz;

            _battle1 = battleArena1;

            _battle2 = battleArena2;

            _battle3 = battleArena3;

            _tr = training;

            merchant.add();
            merchant.add();
            merchant.add();
            merchant.add();
            trainer.add();
        }

        public void playerDidEnterRoom(Notification notification)
        {
            Player player = (Player)notification.Object;
            Room room = player.currentRoom;

            if (room == store)
            {
                Console.WriteLine("Welcome to the store how can I help you?\nYou can use buy/sell Commmand or you can use the go Command");
                merchant.ShowInventory();


            }

            if (room == store1)
            {
                Console.WriteLine("Welcome to the store how can I help you?");
                merchant.ShowInventory();


            }

            if (room == store2)
            {
                Console.WriteLine("Welcome to the store how can I help you?");
                merchant.ShowInventory();


            }

            if (room == store3)
            {
                Console.WriteLine("Welcome to the store how can I help you?");
                merchant.ShowInventory();


            }

            if (room == tr)
            {
                int i = 500;
                Random random = new Random();
                int k = trainer.CountPow();
                Console.WriteLine("It costs " + i + " to get a new power will you pay? yes or no");
                int j = random.Next(0, k);
                if (Console.ReadLine() == "yes")
                {
                    if (k != 0)
                    {
                        if (player.money >= i)
                        {
                            Powers powers = trainer.FindPower(j);
                            player.money -= i;
                            Console.WriteLine("You learn " + powers.name);
                            player.magicArray.Add(powers);
                            trainer.RemovePow(j);
                            room = _forrest;
                        }
                        else
                        {
                            Console.WriteLine("Money is too low");
                            room = _forrest;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You learn all the powers");
                        room = _forrest;
                    }
                }
                else
                {
                    player.currentRoom = _forrest;
                }



            }

            if (room == battle)
            {
                BattleSystem battle = new BattleSystem();
                Random random = new Random();
                int i = random.Next(0, 8);
                int money = random.Next(10, 150);
                Console.WriteLine("You can use the use, inventory, and cast command when you're in battle.");
                if (i < 3)
                {
                    Console.WriteLine("You're in Battle with a Low class warrior");
                    battle.battle(player, new LowClassWarrior());
                    player.maxHealth += random.Next(25, 100);
                    player.maxMagic += random.Next(25, 50);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(10, 30));
                    Console.WriteLine("You're Health and Magic went up!");

                }
                if (i >= 3 && i < 6)
                {
                    Console.WriteLine("You're in Battle a Med class warrior");
                    battle.battle(player, new MedClassWarrior());
                    player.maxHealth += random.Next(50, 100);
                    player.maxMagic += random.Next(25, 75);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(30, 65));
                    Console.WriteLine("You're Health and Magic went up!");


                }
                if (i >= 6 && i < 9)
                {
                    Console.WriteLine("You're in Battle with a High Class Warrior");
                    battle.battle(player, new HighClassWarrior());
                    player.maxHealth += random.Next(100, 150);
                    player.maxMagic += random.Next(50, 100);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(65, 100));
                    Console.WriteLine("You're Health and Magic went up!");

                }

                if(player.maxHealth >= 500 && player.power >= 3)
                {
                    Console.WriteLine("You are storng, I think you're ready to battle the warrior king.");
                }


            }
            if (room == _medi)
            {
                Console.WriteLine("To fully restore your you health and magic it will cost 100 money");
                Console.WriteLine("Do you want to spend 100 money Yes or No?");
                if (Console.ReadLine() == "yes")
                {
                    if (player.money >= 100)
                    {
                        player.health = player.maxHealth;
                        player.magic = player.maxMagic;
                        player.money -= 100;
                        Console.WriteLine("Thank you, Your health and magic has been fully restore");
                        room = _entrance;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we can't help you because of your low money");
                        player.currentRoom = _entrance;
                    }

                }
                else
                {
                    room = _entrance;
                }
            }
            if (room == _medi1)
            {
                Console.WriteLine("To fully restore your you health and magic it will cost 100 money");
                Console.WriteLine("Do you want to spend 100 money yes or no?");
                if (Console.ReadLine() == "yes")
                {
                    if (player.money >= 100)
                    {
                        player.health = player.maxHealth;
                        player.magic = player.maxMagic;
                        player.money -= 100;
                        Console.WriteLine("Thank you, Your health and magic has been fully restore");
                        room = _entrance1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we can't help you because of your low money");
                        player.currentRoom = _entrance1;
                    }

                }
                else
                {
                    room = _entrance1;
                }
            }
            if (room == _medi2)
            {
                Console.WriteLine("To fully restore your you health and magic it will cost 100 money");
                Console.WriteLine("Do you want to spend 100 money Yes or No?");
                if (Console.ReadLine() == "yes")
                {
                    if (player.money >= 100)
                    {
                        player.health = player.maxHealth;
                        player.magic = player.maxMagic;
                        player.money -= 100;
                        Console.WriteLine("Thank you, Your health and magic has been fully restore");
                        room = _entrance2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we can't help you because of your low money");
                        player.currentRoom = _entrance2;
                    }

                }
                else
                {
                    room = _entrance2;
                }
            }
            if (room == _medi3)
            {
                Console.WriteLine("To fully restore your you health and magic it will cost 100 money");
                Console.WriteLine("Do you want to spend 100 money Yes or No?");
                if (Console.ReadLine() == "yes")
                {
                    if (player.money >= 100)
                    {
                        player.health = player.maxHealth;
                        player.magic = player.maxMagic;
                        player.money -= 100;
                        Console.WriteLine("Thank you, Your health and magic has been fully restore");
                        room = _entrance3;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we can't help you because of your low money");
                        player.currentRoom = _entrance3;
                    }

                }
                else
                {
                    room = _entrance3;
                }
            }

            if (room == _king1)
            {
                BattleSystem battle = new BattleSystem();
                
                if(warriorKingDow == false)
                {
                    Console.WriteLine("So you want to fight me hun this will be your last battle becuase you'll be dead");
                    Console.WriteLine("You're in Battle with the Warrior King");
                    battle.battle(player, new WarriorKing());
                    player.money += 500;
                    Console.WriteLine("You earned 500 money");
                    player.powUp(1000);
                    warriorKingDow = true;
                    _entrance.setExit("forrest", _forrest);
                }
                
                else
                {
                    Console.WriteLine("You've beat the Warrior King now it's on the greater enemies");
                    player.currentRoom = _entrance;

                }
                
            }

            if(room == ww)
            {
                BattleSystem battle = new BattleSystem();

                if (WizDow1 == false)
                {
                    Console.WriteLine("The water is flowing you will battle me");
                    Console.WriteLine("You're in Battle with the Master water wizard");
                    battle.battle(player, new MasterWaterWiz());
                    player.money += 1000;
                    Console.WriteLine("You earned 1000 money");
                    player.powUp(2000);
                    WizDow1 = true;
                    _forrest.setExit("earth", _entrance2);

                }

                else
                {
                    Console.WriteLine("You've beat the master fire wizard now it's on the world of earth");
                    player.currentRoom = _entrance1;

                }
            }

            if(room == ew)
            {
                BattleSystem battle = new BattleSystem();

                if (WizDow2 == false)
                {
                    Console.WriteLine("The earth is shaking you will battle me");
                    Console.WriteLine("You're in Battle with the Master earth wizard");
                    battle.battle(player, new MasterEarthWiz());
                    player.money += 2000;
                    Console.WriteLine("You earned 2000 money");
                    player.powUp(3000);
                    WizDow2 = true;
                    _forrest.setExit("fire", _entrance3);
                }

                else
                {
                    Console.WriteLine("You've beat the master earth wizard now it's on the world of fire");
                    player.currentRoom = _entrance2;

                }
            }

            if (room == fw)
            {
                BattleSystem battle = new BattleSystem();

                if (WizDow3 == false)
                {
                    Console.WriteLine("I will burn you to death");
                    Console.WriteLine("You're in Battle with the Master fire wizard");
                    battle.battle(player, new MasterFireWiz());
                    player.money += 3000;
                    Console.WriteLine("You earned 3000 money");
                    player.powUp(5000);
                    WizDow3 = true;
                    _forrest.setExit("master", _mw);
                }

                else
                {
                    Console.WriteLine("You've beat the master fire wizard now it's time to battle the god wizard");
                    player.currentRoom = _entrance3;

                }
            }

            if (room == mw)
            {
                BattleSystem battle = new BattleSystem();

                if (WizDow3 == false)
                {
                    Console.WriteLine("You want to battle me i'm a god");
                    Console.WriteLine("You're in Battle with the god wizard");
                    battle.battle(player, new GodWiz());
                    Console.WriteLine("You have won the game congrats");
                    System.Environment.Exit(0);
                }
            }

            if (room == _battle1)
            {
                BattleSystem battle = new BattleSystem();
                Random random = new Random();
                int i = random.Next(0, 8);
                int money = random.Next(150, 225);
                if (i < 3)
                {
                    Console.WriteLine("You're in Battle with a Low level water wizard");
                    battle.battle(player, new LowWaterWiz());
                    player.maxHealth += random.Next(150, 200);
                    player.maxMagic += random.Next(100, 150);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(100, 150));
                    Console.WriteLine("You're Health and Magic went up!");

                }
                if (i >= 3 && i < 6)
                {
                    Console.WriteLine("You're in Battle a Med level water wizard");
                    battle.battle(player, new MedWaterWiz());
                    player.maxHealth += random.Next(200, 250);
                    player.maxMagic += random.Next(150, 200);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(150, 200));
                    Console.WriteLine("You're Health and Magic went up!");


                }
                if (i >= 6 && i < 9)
                {
                    Console.WriteLine("You're in Battle with a High level water wizard");
                    battle.battle(player, new HighWaterWiz());
                    player.maxHealth += random.Next(250, 300);
                    player.maxMagic += random.Next(200, 250);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(200, 250));
                    Console.WriteLine("You're Health and Magic went up!");

                }

            }

            if (room == _battle2)
            {
                BattleSystem battle = new BattleSystem();
                Random random = new Random();
                int i = random.Next(0, 8);
                int money = random.Next(225, 275);
                if (i < 3)
                {
                    Console.WriteLine("You're in Battle with a Low level earth wizard");
                    battle.battle(player, new LowEarthWiz());
                    player.maxHealth += random.Next(300, 350);
                    player.maxMagic += random.Next(250, 300);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(250, 300));
                    Console.WriteLine("You're Health and Magic went up!");

                }
                if (i >= 3 && i < 6)
                {
                    Console.WriteLine("You're in Battle a Med level earth wizard");
                    battle.battle(player, new MidEarthWiz());
                    player.maxHealth += random.Next(350, 400);
                    player.maxMagic += random.Next(300, 350);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(300, 350));
                    Console.WriteLine("You're Health and Magic went up!");


                }
                if (i >= 6 && i < 9)
                {
                    Console.WriteLine("You're in Battle with a High level earth wizard");
                    battle.battle(player, new HighEarthWiz());
                    player.maxHealth += random.Next(400, 450);
                    player.maxMagic += random.Next(350, 400);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(350, 400));
                    Console.WriteLine("You're Health and Magic went up!");

                }
            }

            if (room == _battle3)
            {
                BattleSystem battle = new BattleSystem();
                Random random = new Random();
                int i = random.Next(0, 8);
                int money = random.Next(275, 315);
                if (i < 3)
                {
                    Console.WriteLine("You're in Battle with a Low level earth wizard");
                    battle.battle(player, new LowFireWiz());
                    player.maxHealth += random.Next(450, 500);
                    player.maxMagic += random.Next(400, 450);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(400, 450));
                    Console.WriteLine("You're Health and Magic went up!");

                }
                if (i >= 3 && i < 6)
                {
                    Console.WriteLine("You're in Battle a Med level fire wizard");
                    battle.battle(player, new MedFireWiz());
                    player.maxHealth += random.Next(500, 550);
                    player.maxMagic += random.Next(450, 500);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(450, 500));
                    Console.WriteLine("You're Health and Magic went up!");


                }
                if (i >= 6 && i < 9)
                {
                    Console.WriteLine("You're in Battle with a High level fire wizard");
                    battle.battle(player, new HighFireWiz());
                    player.maxHealth += random.Next(550, 600);
                    player.maxMagic += random.Next(500, 550);
                    Console.WriteLine("You earned " + money + " money");
                    player.money += money;
                    player.powUp(random.Next(500, 550));
                    Console.WriteLine("You're Health and Magic went up!");

                }
            }

        }

        
    }
}
