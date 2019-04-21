using System;

namespace GameEngine.Role
{
	public class Enemy : Character
	{
		public Enemy(string name, int hp, int ap) : base(name, hp, ap)
		{
		}

		public override void Attack(Character enemy)
		{
			base.Attack(enemy);
			Console.WriteLine($"{Name} ����, �y���F{AttackPoint}�I�ˮ`");
		}
	}
}