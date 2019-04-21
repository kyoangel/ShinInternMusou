using System.Linq;

namespace GameEngine.Role
{
	public abstract class Character
	{
		protected Character(string name, int hp, int ap)
		{
			Name = name;
			HitPoint = hp;
			MaxHitPoint = hp;
			AttackPoint = ap;
		}

		public int AttackPoint { get; protected set; }
		public int HitPoint { get; protected internal set; }
		public string JobTitle => this.GetType().ToString().Split('.').Last();
		public int MaxHitPoint { get; }
		public string Name { get; }

		public virtual void Attack(Character enemy)
		{
			enemy.HitPoint -= AttackPoint;
		}
	}
}