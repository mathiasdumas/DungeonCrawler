using System;
namespace DungeonCrawler
{
	public class AddHP : ITrigerrable
	{
		public AddHP()
		{
		}

		public void Trigger(Characteristic characeristic, Characteristic characteristic1)
		{
			int damageDealt = characteristic1.HP - characeristic.Attack;
			characeristic.HP += damageDealt;
		}

		public void Trigger(Characteristic characteristic)
		{
			characteristic.HP += 5;
		}

	}
}

