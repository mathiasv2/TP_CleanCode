using System;
using MiniRPGG;

namespace MiniRPG
{
	public class GameManager
	{
        static Weapon BFSword = new Weapon("BF SWORD", 200);
        static Armor BrambleVest = new Armor("Bramble vest", 120);

        public GameManager()
		{
		}

		public static int GenerateRandomNumber(int min, int max)
		{
			Random random = new Random();
			int GeneratedNumber = random.Next(min, max + 1);
			return GeneratedNumber;
		}

		public static void DisplayHeroInfo(Hero hero)
		{
			Console.WriteLine($"{hero.Name} : HP : {hero.Healthpoint}, \n  Attack : {hero.Attack}, \n Defense : {hero.Defense} Special Actions Points : {hero.SpecialActionPoints}");
		}

		public static void DisplayMessageAction(string message)
		{
			Console.WriteLine(message);
		}

		public static string WhatActionWouldLikeToDo(Hero hero)
		{
			string command;
			DisplayMessageAction($"What would you like to do {hero.Name}");
			DisplayMessageAction("Press A to attack \n Press D to defend yourself \n Press I to display informations of your charaacter \n Press B to backstab the enemy for 1 action point \n Press W to equipe a BF Sword for rest of battle \n Press R to equipe Bramble Vest for rest of Battle");
			command = Console.ReadLine();

			return command;

			
		}

		public static void ProceedCommand(string command, Hero hero, Ennemy enemy)
		{

            if (command.ToUpper() == "A")
				hero.OrderAttack(enemy);

			if (command.ToUpper() == "D")
				hero.OrderDefense();

			if (command.ToUpper() == "I")
			{
                GameManager.DisplayHeroInfo(hero);
				WhatActionWouldLikeToDo(hero);
            }

			if (command.ToUpper() == "B")
				if (hero.SpecialActionPoints < 1)
				{
					hero.OrderBackstab(enemy);
					hero.SpecialActionPoints--;
                }

			if (command.ToUpper() == "W")
                hero.EquipWeapon(BFSword);

			if (command.ToUpper() == "R")
				hero.EquipArmor(BrambleVest);

        }

        public static void GameLoop(Hero hero, Ennemy ennemy)
		{
			int ennemyLevel = 1;
			while(hero.Healthpoint > 0)
			{
				string command = WhatActionWouldLikeToDo(hero);
				ProceedCommand(command, hero, ennemy);
				if(ennemy.Healthpoint <= 0)
				{
					DisplayMessageAction("The enemy has been defeated, next ennemy incoming");
					Ennemy.EnnemyLevelUp();

				}
			}
		}

		




	}
}

