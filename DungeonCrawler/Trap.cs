using System;
namespace DungeonCrawler
{
	public class Trap : Encounter
	{
		public ITrigerrable trigerrable { get; set; }
        
        public override void Meet(Hero hero)
        {
            RemoveHP HPRemover = new RemoveHP();
            HPRemover.Trigger(hero.Characteristic);
            Console.WriteLine($"le héro est tombé sur un piège et est maintenant à {hero.Characteristic.HP}");
        }
    }
}

