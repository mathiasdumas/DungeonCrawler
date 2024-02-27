using System;
namespace DungeonCrawler
{
	public class RemoveAttack : ITrigerrable
	{

		public RemoveAttack()
		{
		}

		public void Trigger(Characteristic characteristic)
		{
			characteristic.Attack -= 5;
		}
	}
}

