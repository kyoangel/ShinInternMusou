using System;

namespace GameEngine.Role
{
	public class Priest : Character, IHero
	{
		public Priest(string name) : base(name, 25, 6)
		{
		}

		public override void Attack(Character enemy)
		{
			base.Attack(enemy);
			Console.WriteLine($"Priest {Name}, 用華麗的法杖攻擊, 造成了{AttackPoint}點傷害");
		}

		public void Skill(Character enemy)
		{
			var skillPoint = AttackPoint * 2;
			HitPoint += skillPoint;
			HitPoint = MaxHitPoint >= HitPoint ? HitPoint : MaxHitPoint;
			Console.WriteLine($"Priest {Name}, 用恢復法術, 造成了{skillPoint}點回復");
		}
	}
}