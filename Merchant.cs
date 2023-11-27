using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Merchant
    {
        public List<Item> Inventory = new List<Item>(); // All the item that the merchant have
        private int _money = 100; // The money that the merchant have 
        public int i = 0;
        public int j = 0;
        public int k = 0;
        public int l = 0;
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
        public void add() // Use to add items to merchant
        {
            for(int i = 0; i < 20; i++)
            {
                Inventory.Add(new SmallHealthRecovery());
                Inventory.Add(new LargeHealthRecovery());
                Inventory.Add(new SmallMagicRecovery());
                Inventory.Add(new LargeMagicRecovery());

            }
        }
        public void ShowInventory() // Use to show the number of items that the merchant has
        {
            
            foreach (Item item in Inventory)
            {
                //Console.WriteLine(item.name); 
                if(item.name == new SmallHealthRecovery().name)
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
                Console.WriteLine("Out of items");
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

        public bool FindInventory(String word) 
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
        public int FindInventoryByPos(Item item)
        {
            int p = 0;
            int t = 0;
            foreach (Item i in Inventory)
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


        public void buy(Player player, Item item) // use to buy an item and put it in the player's inventory
        {
            if (FindInventory(item.name) == true)
            {
                if(item.price <= player.money && item.weight + player.weight <= player.maxWeight)
                {
                    player.addInventory(item);
                    player.money -= item.price;
                    Console.WriteLine("You've purchase " + item.name);
                    Inventory.RemoveAt(FindInventoryByPos(item));

                }
                else
                {
                    Console.WriteLine("Low Money or Too much weight");
                }
            }
            else
            {
                Console.WriteLine("Sorry we're out of " + item.name);
            }
        }

        public void sell(Player player, Item item) // use for the player to sell a item to the merchant if the merchant has the money
        {
            if (player.FindInventory(item.name))
            {
                if (item.price <= money)
                {
                    player.dropFormInventory(item);
                    player.money += item.price;
                    Inventory.Add(item);
                    Console.WriteLine("You sold " + item.name);

                }
                else
                {
                    Console.WriteLine("Sorry I don't have money");
                }
            }
            else
            {
                Console.WriteLine("Don't have that");
            }
        }
    }
}
