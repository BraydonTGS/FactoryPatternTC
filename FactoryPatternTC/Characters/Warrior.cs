using System;
using static System.Console;
namespace FactoryPatternTC
{
    public class Warrior : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Warrior(string name)
        {
            Name = name;
            Level = 1;
            Health = 50;
            WriteLine($"> Warrior {Name} has Been Created");
        }

        public void Attact()
        {
            WriteLine($"> Warrior {Name} is attacking");
            ReadKey();
        }
    }
}

