using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame
{
    class GodWiz : Enemy
    {
        public GodWiz() : base()
        {
            this.health = 30000;
            this.magic = 100000;
            this.maxHealth = 30000;
            this.maxMagic = 100000;
            this.power = 20;
            this.count = 0;
            this.magicList = new List<Powers>();
            magicList.Add(new Hit());
            magicList.Add(new Kick());
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
        override
        public void logic()
        {
            if(this.count <= 0 && health <= 1000)
            {
                Console.WriteLine("I will unleash the power of a god!");
                power += 5;

            }

        }
    }
}
