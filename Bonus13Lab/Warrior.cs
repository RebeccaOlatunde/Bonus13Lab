using System;

namespace Bonus13Lab
{
    public class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }
        public Warrior(string weaponType, string name, int strength, int intelligence) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"{WeaponType}");
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Strength}");
            Console.WriteLine($"{Intelligence}");
        }

    }
}
