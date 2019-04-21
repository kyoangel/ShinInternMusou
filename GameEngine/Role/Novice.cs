using System;

namespace GameEngine.Role
{
	public class Novice : Character
	{
		public Novice(string name, int hp, int ap) : base(name, hp, ap)
		{
		}

		public override void Attack(Character enemy)
		{
			base.Attack(enemy);
			Console.WriteLine($"Novice {Name}, 用笨拙的小刀攻擊, 造成了{AttackPoint}點傷害");
		}
	}
}