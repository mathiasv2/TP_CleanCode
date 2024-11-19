using System;
namespace MiniRPGG
{
	public class Ennemy
	{
		public string Name { get; set; }
		public int Healthpoint { get; set; }
		public int Attack { get; set; }
		public int Defense { get; set; }
		public int Level { get; set; }


		public Ennemy()
        {
            Name = "Sbire";
            Healthpoint = 100;
            Attack = 12;
            Defense = 4;
			Level = 1;
        }

		public void EnnemyLevelUp()
		{
            Level++;
			Healthpoint *= Level;
			Attack *= Level;
			Defense *= Level;
		}
    }
}

