using System;
namespace Bonus13Lab
{
    public class GameCharacter  
    {
       
            public string Name { get; set; }
            public int Strength { get; set; }
            public int Intelligence { get; set; }

            public GameCharacter(string name, int strength, int intelligence)
            {
             Name = name;
             Strength = strength;
             Intelligence = intelligence;
            }

        public virtual void Play()
            {

             Console.WriteLine($"{Name}");

             Console.WriteLine($"{Strength}");

             Console.WriteLine($"{Intelligence}");

            }




    }
} 
   
