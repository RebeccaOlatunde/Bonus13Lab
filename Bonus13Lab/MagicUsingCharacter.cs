using System;
namespace Bonus13Lab
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(int magicalEnergy, string name, int strength, int intelligence): base(name, strength,intelligence)
            
        {
            MagicalEnergy = magicalEnergy;
        }


        public override void Play()
        {

            Console.WriteLine($"{MagicalEnergy}");

            Console.WriteLine($"{Name}");

            Console.WriteLine($"{Strength}");

            Console.WriteLine($"{Intelligence}");

        }

    }   

}

