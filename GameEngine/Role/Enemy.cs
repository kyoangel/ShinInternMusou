using System;

namespace GameEngine.Role
{
	public class Enemy : Character
	{
		public Enemy(string enemyName, int hp, int ap) : base(enemyName, hp, ap)
		{
		}

		public override void Attack(Role.Character enemy)
		{
			base.Attack(enemy);
			Console.WriteLine($"{Name} ����, �y���F{AttackPoint}�I�ˮ`");
		}
	}
}