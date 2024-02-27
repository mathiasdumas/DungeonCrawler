using System;
namespace DungeonCrawler
{
	public class Characteristic
	{
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }

        public Characteristic()
        {
        }

        public Characteristic(int hp, int attack, int speed)
        {
            HP = hp;
            Attack = attack;
            Speed = speed;
        }


    }
}

