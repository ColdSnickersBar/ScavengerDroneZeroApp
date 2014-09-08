using System;
using SdzApp.Math;

namespace SdzApp.GameObject
{
	public interface IAttackable
	{
		Vector2 Position {
			get;
			set;
		}

		int Defend (int power, int attackDice);

	}

}

