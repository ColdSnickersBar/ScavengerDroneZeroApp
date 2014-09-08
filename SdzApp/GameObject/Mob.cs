using System;
using SdzApp.Math;

namespace SdzApp.GameObject
{
	public class Mob : IAttackable
	{
		public Vector2 Position {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public IWeapon Weapon {
			get;
			private set;
		}

		public int AttackSkill {
			get;
			set;
		}

		public void Equip (IWeapon weapon)
		{
			Weapon = weapon;
		}

		public void Attack (IAttackable target)
		{
			Weapon.Attack (target, AttackSkill);
		}

		#region IAttackable implementation
		public int Defend (int power, int attackDice)
		{
			throw new NotImplementedException ();
		}
		#endregion


		public Mob ()
		{
		}
	}
}

