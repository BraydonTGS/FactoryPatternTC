using System;
using static System.Console;
namespace FactoryPatternTC
{
    public class Mage : ICharacter
    {

        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int Health { get; set; }

        public Mage(string name)
        {
            Name = name;
            Health = 25;
            WriteLine("A Mage has Been Created");
        }

        public void Attact()
        {
            WriteLine($"A Mage {Name} is attacking");
            ReadKey();
        }
    }
}

