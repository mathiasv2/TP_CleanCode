using System;
using MiniRPGG;

namespace MiniRPG
{
	public class Hero
	{
		public string Name { get; set; }
		public int Healthpoint { get; set; }
		public int Attack { get; set; }
		public int Defense { get; set; }
		public int SpecialActionPoints { get; set; }
		public Weapon Weapon { get; set; }
		public Armor Armor { get; set; }
		public List<Item> Items { get; set; }

		public Hero()
		{
		}

        public Hero(string name, int healthpoint, int attack, int defense, int specialActionPoints)
        {
            Name = name;
            Healthpoint = healthpoint;
            Attack = attack;
            Defense = defense;
			Weapon = Weapon;
			Armor = Armor;
			SpecialActionPoints = specialActionPoints;
        }

		public void EquipWeapon(Weapon weapon)
		{
			this.Weapon = weapon;
			this.Attack += weapon.Attack;
		}

		public void EquipArmor(Armor armor)
		{
			this.Armor = armor;
			this.Defense += armor.Defense;
		}

		public void OrderAttack(Ennemy target)
		{
			target.Healthpoint -= this.Attack;
		}

		public void OrderDefense()
		{
			this.Defense += GameManager.GenerateRandomNumber(1, 15);  
		}

		public void OrderBackstab(Ennemy target)
		{
			target.Healthpoint -= this.Attack * 2;
			this.SpecialActionPoints -= 1;
		}


    }
}

