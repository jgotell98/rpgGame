using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    public abstract class Enemy
    {
        List<Powers> _magicList; // Stores enemy powers
        private int _health;
        private int _maxHealth;
        private int _power;
        private int _magic;
        private int _maxMagic;
        private int _count;
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
        public int count 
        { 
            get 
            {
                return _count; 
            } 
            set 
            { 
                _count = value; 
            } 
        }
        public List<Powers> magicList
        {
            get
            {
                return _magicList;
            }
            set
            {
                _magicList = value;
            }
        }
        
        public Powers returnPowers(int i) // To return the power so it can be use for the battle system
        {
            Powers powers;
            foreach(Powers p in magicList)
            {
                if(magicList.IndexOf(p) == i)
                {
                    powers = p;
                    return powers;
                }
            }
            return null;
        }
        public abstract void logic(); // Is use for the battle system to give some enemies logic 
    }
}
