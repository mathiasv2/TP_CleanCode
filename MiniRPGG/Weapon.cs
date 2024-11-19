using System;
namespace MiniRPG
{
	public class Weapon
	{
		public string Name { get; set; }
		public int Attack { get; set; }

		public Weapon()
		{
		}

        public Weapon(string name, int attack)
        {
            Name = name;
            Attack = attack;
        }

    }
}

