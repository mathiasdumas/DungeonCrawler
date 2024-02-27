using System;
namespace DungeonCrawler
{
	public class Room
	{
        Encounter EncounterFaced { get; set; }
        Hero hero1 { get; set; }

        public Room()
		{
            Generate();
        }

        public void Generate()
        {
            hero1 = new Hero("ploup", new Characteristic(100, 10, 10));
            Random random = new Random();
            while (hero1.Characteristic.HP > 0)
            {
                int chance = random.Next(0, 101);
                if (chance <= 50)
                {
                    EncounterFaced = new Monster(new Characteristic(random.Next(0, 15), random.Next(1, 8), random.Next(1, 9)));
                    EncounterFaced.Meet(hero1);
                }
                else if (chance > 50 && chance <= 75)
                {
                    EncounterFaced = new Item();
                    EncounterFaced.Meet(hero1);
                }
                else if (chance > 75)
                {
                    EncounterFaced = new Trap();
                    EncounterFaced.Meet(hero1);
                }
            }
        }


	}
}

