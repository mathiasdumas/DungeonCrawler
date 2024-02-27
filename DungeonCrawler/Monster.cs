using System;
namespace DungeonCrawler
{
	public class Monster : Encounter
	{
        public Characteristic Characteristic { get; set; }
        public ITrigerrable trigerrable { get; set; }
        RemoveHP HPRemover = new RemoveHP();

        public Monster(Characteristic characteristic) 
        {
            Characteristic = characteristic;
        }

        public override void Meet(Hero hero)
        {
            
            while (Characteristic.HP >= 0)
            {

                Console.WriteLine($"monstre hp : {Characteristic.HP}");
                HPRemover.Trigger(hero.Characteristic, Characteristic);
            }
        }
    }
}

