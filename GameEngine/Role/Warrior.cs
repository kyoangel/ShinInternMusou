﻿using System;

namespace GameEngine.Role
{
	public class Warrior : Character, IHero
	{
		public Warrior(string name, int hp, int ap) : base(name, hp, ap)
		{
		}

		public override void Attack(Character enemy)
		{
			base.Attack(enemy);
			Console.WriteLine($"Warrior {Name}, 用威猛的大斧攻擊, 造成了{AttackPoint}點傷害");
		}

		public void Skill(Character enemy)
		{
			var skillAttackPoint = AttackPoint * 2;
			enemy.HitPoint -= skillAttackPoint;
			Console.WriteLine($"Warrior {Name}, 用致命攻擊技能, 造成了{skillAttackPoint}點傷害");
		}
	}
}