using System;
namespace DungeonCrawler
{
    public class Hero
    {
        public string Name { get; set; }
        public Characteristic Characteristic{ get; set; }
        List<ITrigerrable> abilities = new List<ITrigerrable>();

        public Hero(string name, Characteristic characteristic)
        {
            Name = name;
            Characteristic = characteristic;
        }
    }
}

