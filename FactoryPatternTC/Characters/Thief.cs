using System;
using static System.Console;
namespace FactoryPatternTC
{
    public class Thief : ICharacter
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Thief(string name)
        {
            Name = name;
            Level = 1;
            Health = 30;
            WriteLine("A Thief has Been Created");
        }

        public void Attact()
        {
            WriteLine($"Thief {Name} is attacking");
            ReadKey();
        }
    }
}

