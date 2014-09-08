using System;

namespace SdzApp.GameObject
{
	public class Weapon : IWeapon
	{
		public int Power {
			get;
			set;
		}

		public float Range {
			get;
			set;
		}

		#region IWeapon implementation

		public void Attack (IAttackable mob, int attackDice)
		{

		}

		#endregion
	}
}

