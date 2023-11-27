using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    public abstract class Item
    {
        private String _name;
        public string name { get { return _name; } set { _name = value; } }
        private bool doHeal; // To show that this item is to heal
        private bool doMag; // To show that this item is to regain magic
        private int _price; // The price of the item
        private int _weight; // The weight of the item
        public bool heal { get { return doHeal; } set { doHeal = value; } }
        public bool mag { get { return doMag; } set { doMag = value; } }
        public int price { get { return _price;  } set { _price = value; } }
        public int weight { get { return _weight; } set { _weight = value; } }
        public Item()
        {
            this.name = "";
            this.heal = false;
            this.mag = false;
            this.price = 0;
            this.weight = 0;
        }
        public abstract void execute(Player player); // For the player to use the item

    }
}
