using NUnit.Framework;
using System;
using SdzApp.GameObject;

namespace Equipment
{
	[TestFixture ()]
	public class Equipping
	{
		Mob _mob;

		[Test ()]
		public void MobCanEquipWeapon ()
		{
			var weapon = NSubstitute.Substitute.For<IWeapon> ();
			_mob = new Mob ();
			_mob.Equip (weapon);

			Assert.AreEqual (weapon, _mob.Weapon);
		}
	}
}

