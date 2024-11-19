using System;
namespace MiniRPG
{
	public class Armor
	{
		public string Name { get; set; }
		public int Defense { get; set; }

		public Armor()
		{
		}

        public Armor(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }
    }
}

