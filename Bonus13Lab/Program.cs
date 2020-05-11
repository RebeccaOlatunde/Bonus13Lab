using System;

namespace Bonus13Lab
{
    class Program
    {
        static void Main(string[] args)


        {
            

            var gameCharacter = new GameCharacter[5];

            gameCharacter[0] = new Warrior("sword", "Joe",35,15);
            gameCharacter[1] = new Warrior("axe","Doga", 55, 10);

            gameCharacter[2] = new Wizard(12, 45, " Madi", 65, 65);
            gameCharacter[3] = new Wizard(45, 55, "G", 95, 45);
            gameCharacter[4] = new Wizard(95, 65, "Toti", 15, 60);

            foreach (var character in gameCharacter)
            {
             character.Play();
              Console.WriteLine();
            }







        }
    }
}
