using System;
using GameEngine.Enum;
using GameEngine.Role;

namespace GameEngine
{
	public static class CharacterFactory
	{
		public static Character CreateCharacter(string heroName, HeroClass heroClass)
		{
			Character character = null;
			switch (heroClass)
			{
				case HeroClass.Novice:
					character = new Novice(heroName, 20, 3);
					break;

				case HeroClass.Warrior:
					character = new Warrior(heroName, 30, 5);
					break;

				case HeroClass.Priest:
					character = new Priest(heroName, 25, 3);
					break;

				default:
					throw new ArgumentOutOfRangeException(nameof(heroClass), heroClass, null);
			}
			return character;
		}

		public static Character CreateEnemy(string enemyName)
		{
			var enemy = new Enemy(enemyName, 15, 3);
			return enemy;
		}
	}
}