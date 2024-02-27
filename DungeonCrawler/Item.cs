using System;
namespace DungeonCrawler
{
    public class Item : Encounter
    {
        public ITrigerrable Trigerrable { get; set; }
        

        public override void Meet(Hero hero)
        {
            AddHP HPAdder = new AddHP();
            HPAdder.Trigger(hero.Characteristic);
            Console.WriteLine($"le héro a trouvé un item et est à {hero.Characteristic.HP}");
        }
        
    }
}

