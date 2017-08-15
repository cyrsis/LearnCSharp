﻿using System;


namespace DynamicSpecFlowTests
{
    public class PlayerCharacter
    {
        public int Health { get; private set; } = 100;
        public bool IsDead { get; private set; }
        public int DamageResistance { get; set; }
        public string Race { get; set; }

        //public int MagicalPower
        //{
        //    get { return MagicalItems.Sum(x => x.Power); }
        //}

        //public List<MagicalItem> MagicalItems { get; set; } = new List<MagicalItem>();
        //public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        //public CharacterClass CharacterClass { get; set; }

        public DateTime LastSleepTime { get; set; }

        //public int WeaponsValue
        //{
        //    get { return Weapons.Sum(x => x.Value); }
        //}

        public void Hit(int damage)
        {
            var raceSpecfifcDamageResistance = 0;

            if (Race == "Elf")
            {
                raceSpecfifcDamageResistance = 20;
            }

            var totalDamageTaken =
                Math.Max(damage - raceSpecfifcDamageResistance - DamageResistance, 0);

            Health -= totalDamageTaken;

            if (Health <= 0)
            {
                IsDead = true;
            }
        }
    }
}