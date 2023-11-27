using System.Collections;
using System.Collections.Generic;
using System;

namespace StarterGame
{
    public class Player
    {
        public List<Item> Inventory = new List<Item>(); // Holds item
        public List<Powers> magicArray = new List<Powers>(); // Holds powers
        private Room _currentRoom = null;
        private int _health = 100; // Current health of the player
        private int _maxHealth = 100; // The max health that the player can have
        private int _power = 1; // Power level of the player the higher the level the more damage your attacks gives 
        private int _magic = 100; // Current magic of the player
        private int _maxMagic = 100; // The max magic that the player can have
        private int _weight = 0; // The current weight that the player is holding
        private int _maxWeight = 50; // The max weight a player can carry
        private int _money = 15; // The money that the player has
        private int _exp = 0; // The current exp ponts the player has
        private int _maxExp = 1000; // The max exp ponts to level up
        public int i = 0;
        public int j = 0;
        public int k = 0;
        public int l = 0;
       
        public Room currentRoom
        {
            get
            {
                return _currentRoom;
            }
            set
            {
                _currentRoom = value;
            }
        }

        public int health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        public int maxHealth
        {
            get
            {
                return _maxHealth;
            }
            set
            {
                _maxHealth = value;
            }
        }
        public int power
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
            }
        }
        public int magic
        {
            get
            {
                return _magic;
            }
            set
            {
                _magic = value;
            }
        }
        public int maxMagic
        {
            get
            {
                return _maxMagic;
            }
            set
            {
                _maxMagic = value;
            }
        }
        public int weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
        public int maxWeight
        {
            get
            {
                return _maxWeight;
            }
            set
            {
                _maxWeight = value;
            }
        }
        public int money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
            }
        }
        public int exp
        {
            get
            {
                return _exp;
            }
            set
            {
                _exp = value;
            }
        }
        public int maxExp
        {
            get
            {
                return _maxExp;
            }
            set
            {
                _maxExp = value;
            }
        }
        

        public Player(Room room)//, GameOutput output)
        {
            _currentRoom = room;
        }

        public void waltTo(string direction)
        {
            Room nextRoom = this._currentRoom.getExit(direction);
            if (nextRoom != null)
            {
                Notification notification = new Notification("PlayerWillEnterRoom");
                NotificationCenter.Instance.postNotification(notification);
                this._currentRoom = nextRoom;
                notification = new Notification("PlayerDidEnterRoom", this);
                NotificationCenter.Instance.postNotification(notification);
                this.outputMessage("\n" + this._currentRoom.description());
            }
            else
            {
                this.outputMessage("\nThere is no door on " + direction);
            }
        }

        public void outputMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void powUp(int i) // if Exp points gets to the max it will power up the player and the max will double
        {
            exp += i;
            if (exp >= _maxExp)
            {
                Console.WriteLine("You've power up");
                power++;
                _maxExp = _maxExp * 2;
            }
        }
        
        public String stats() // Shows the player's stats
        {
            return "Health: "+ health + "/" + maxHealth + " Magic: " + magic + "/" + maxMagic + " Power: " + power + " Money: $" + money + " Weight: " + weight + "/" + maxWeight;
        }
        public String battlestats() // Shows the player's stats during battle
        {
            return "Health: " + health + "/" + maxHealth + " Magic: " + magic + "/" + maxMagic;
        }

        public void addInventory(Item item) //Puts items to the Inventory
        {
            if(item.weight + weight < maxWeight)
            {
                Inventory.Add(item);
                weight += item.weight;
            }
            else
            {
                outputMessage("Can not hold it, too much weight");
            }
        }

        public void dropFormInventory(Item item) //Drops items form the Inventory
        {
            
            if (FindInventory(item.name) == true) 
            {                                                       
                        Inventory.RemoveAt(FindInventoryByPos(item));
                        weight -= item.weight;
                        outputMessage(item.name + " is Drop/Use");                                                                                                
            }
            else
            {
                outputMessage(item.name + " is not in the inventory.");
            }
        }
        public void ShowInventory() // Shows the items that the player has
        {
            foreach(Item item in Inventory)
            {
                if (item.name == new SmallHealthRecovery().name)
                {
                    i++;
                }
                if (item.name == new LargeHealthRecovery().name)
                {
                    j++;
                }
                if (item.name == new SmallMagicRecovery().name)
                {
                    k++;
                }
                if (item.name == new LargeMagicRecovery().name)
                {
                    l++;
                }

            }
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Nothing is in the inventory");
            }
            else
            {
                if (i != 0)
                {
                    Console.WriteLine(i + " " + new SmallHealthRecovery().name);
                }
                if (j != 0)
                {
                    Console.WriteLine(j + " " + new LargeHealthRecovery().name);
                }
                if (k != 0)
                {
                    Console.WriteLine(k + " " + new SmallMagicRecovery().name);
                }
                if (l != 0)
                {
                    Console.WriteLine(l + " " + new LargeMagicRecovery().name);
                }
                i = 0;
                j = 0;
                k = 0;
                l = 0;
            }
        }

        public bool FindInventory(String word) // Finds the item by name
        {
            foreach (Item item in Inventory)
            {
                if (item.name == word)
                {
                    
                    return true;
                    
                }
                
            }
            return false;
        }
        public int FindInventoryByPos(Item item) // Finds the item's place in the list
        {
            int p = 0;
            int t = 0;
            foreach(Item i in Inventory)
            {
                if (i == item)
                {
                     p = t;
                }
                else
                {
                    t++;
                }
            }
            return p;
        }
        
         public Item returnItem(string s) // Returns the item that is being use if the player has it
          {
            if(s == new SmallHealthRecovery().name)
            {
                 return new SmallHealthRecovery();
            }
            if(s == new SmallMagicRecovery().name)
            {
                return new SmallMagicRecovery();
            }
            if (s == new LargeHealthRecovery().name)
            {
                return new LargeHealthRecovery();
            }
            if (s == new LargeMagicRecovery().name)
            {
                return new LargeMagicRecovery();
            }
            return null;
            
        }
        public bool FindPower(string word) // Finds the power in the list
        {
            foreach(Powers p in magicArray)
            {
                if(p.name == word)
                {
                    return true;
                }
            }
            return false;

        }
          public Powers returnPower(string word) // Returns the power that is being use if the player has it
        {
            if(word == new Hit().name)
            {
                return new Hit();
            }
            if(word == new Kick().name)
            {
                return new Kick();
            }
            if (word == new MudRush().name)
            {
                return new MudRush();
            }
            if (word == new Boulder().name)
            {
                return new Boulder();
            }
            if (word == new EarthCoffin().name)
            {
                return new EarthCoffin();
            }
            if (word == new Earthquake().name)
            {
                return new Earthquake();
            }
            if (word == new EarthSplter().name)
            {
                return new EarthSplter();
            }
            if (word == new FireBall().name)
            {
                return new FireBall();
            }
            if (word == new FireBlast().name)
            {
                return new FireBlast();
            }
            if (word == new FireBreath().name)
            {
                return new FireBreath();
            }
            if (word == new FireStorm().name)
            {
                return new FireStorm();
            }
            if (word == new FireWave().name)
            {
                return new FireWave();
            }
            if (word == new HighTide().name)
            {
                return new HighTide();
            }
            if (word == new IceBall().name)
            {
                return new IceBall();
            }
            if (word == new LightBall().name)
            {
                return new LightBall();
            }
            if (word == new LightDance().name)
            {
                return new LightDance();
            }
            if (word == new LightStorm().name)
            {
                return new LightStorm();
            }
            if (word == new LightStrike().name)
            {
                return new LightStrike();
            }
            if (word == new Slam().name)
            {
                return new Slam();
            }
            if (word == new Tsunami().name)
            {
                return new Tsunami();
            }
            if (word == new WaterWave().name)
            {
                return new WaterWave();
            }
            if (word == new Whirlpool().name)
            {
                return new Whirlpool();
            }
            return null;
        }


    }

}
