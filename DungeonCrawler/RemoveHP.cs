using System;
namespace DungeonCrawler
{
	public class RemoveHP : ITrigerrable
	{
		public RemoveHP()
		{
		}

		public void Trigger(Characteristic characteristic, Characteristic characteristic1)
		{
			characteristic1.HP -= characteristic.Attack;
			characteristic.HP -= characteristic1.Attack;
		}

        public void Trigger(Characteristic characteristic)
        {
			characteristic.HP -= 5;
        }


    }
}

