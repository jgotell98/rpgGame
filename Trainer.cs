using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class Trainer
    {
        List<Powers> magicList = new List<Powers>();

        public void add()
        {
            magicList.Add(new Slam());
            magicList.Add(new FireBall());
            magicList.Add(new FireWave());
            magicList.Add(new FireBreath());
            magicList.Add(new FireBlast());
            magicList.Add(new FireStorm());
            magicList.Add(new WaterWave());
            magicList.Add(new Whirlpool());
            magicList.Add(new Tsunami());
            magicList.Add(new IceBall());
            magicList.Add(new HighTide());
            magicList.Add(new LightBall());
            magicList.Add(new LightDance());
            magicList.Add(new LightStorm());
            magicList.Add(new LightStrike());
            magicList.Add(new Boulder());
            magicList.Add(new EarthCoffin());
            magicList.Add(new Earthquake());
            magicList.Add(new EarthSplter());
            magicList.Add(new MudRush());

        }

        public Powers FindPower(int i)
        {
            Powers powers = null;
            foreach(Powers p in magicList)
            {
                if(p == magicList[i])
                {
                    powers = p;
                }
            }
            return powers;
        }

        public int FindPowerByPos(Powers powers)
        {
            int p = 0;
            int t = 0;
            foreach (Powers pow in magicList)
            {
                if (pow == powers)
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

        public void RemovePow(int i)
        {
            magicList.RemoveAt(i);
        }
        public int CountPow()
        {
            int k = magicList.Count;
            return k;
        }
    }
}
