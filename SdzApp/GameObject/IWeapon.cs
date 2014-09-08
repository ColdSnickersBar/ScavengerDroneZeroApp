using System;

namespace SdzApp.GameObject
{
	public interface IWeapon
	{
		void Attack (IAttackable mob, int attackDice);
	}
}

