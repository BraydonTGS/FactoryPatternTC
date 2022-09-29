using System;
using static System.Console;
namespace FactoryPatternTC
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public void Attact();
    }
}

