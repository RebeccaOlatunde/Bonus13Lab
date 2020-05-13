using System;
namespace Bonus13Lab
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(int spellNumber, int magicalenergy, string name, int strength, int intelligence):base(magicalenergy, name, strength, intelligence)

        {
            SpellNumber = spellNumber;
        }
        public override void Play()
        {
            Console.WriteLine($"{SpellNumber}");

            Console.WriteLine($"{MagicalEnergy}");

            Console.WriteLine($"{Name}");

            Console.WriteLine($"{Strength}");

            Console.WriteLine($"{Intelligence}");
        }
    }
}
