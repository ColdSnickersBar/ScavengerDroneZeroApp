using NUnit.Framework;
using System;
using SdzApp.GameObject;
using NSubstitute;
using SdzApp.Math;

namespace Combat
{
	[TestFixture ()]
	public class Attacking
	{
		Mob _mob;

		IAttackable _attackable;

		[SetUp]
		public void Setup ()
		{
			_mob = new Mob ();
			_mob.AttackSkill = 2;
		}

		[Test ()]
		public void MobCanAttackWithWeapon ()
		{
			var weapon = Substitute.For<IWeapon> ();
			_mob.Equip (weapon);

			_attackable = Substitute.For<IAttackable> ();

			_mob.Attack (_attackable);

			weapon.Received ().Attack (_attackable, _mob.AttackSkill);
		}

		
		[Test ()]
		public void TestWeaponAttacksTarget ()
		{
			var meleeWeapon = new Weapon ();
			meleeWeapon.Range = 1f;

			_mob.Equip (meleeWeapon);

			_attackable = Substitute.For<IAttackable> ();

			_mob.Attack (_attackable);

			_attackable.Received ().Defend (meleeWeapon.Power, _mob.AttackSkill);
		}

		
		[Test ()]
		public void TestWeaponOnlyAttacksInRange ()
		{
			var meleeWeapon = new Weapon ();
			meleeWeapon.Range = 1f;

			var missileWeapon = new Weapon ();
			missileWeapon.Range = 10f;

			_mob.Equip (meleeWeapon);

			_attackable.Position = new Vector2 (5f, 5f);


		}
	}
}

