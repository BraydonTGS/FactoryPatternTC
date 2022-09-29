using System;
using static System.Console;
namespace FactoryPatternTC
{
    public class World
    {
        public World()
        {
        }
        public void Start()
        {
            WriteLine("> Please Choose Your Character: \n");
            WriteLine("> 1. Warrior \n");
            WriteLine("> 2. Mage \n");
            WriteLine("> 3. Thief \n");
            int userChoice = int.Parse(ReadLine().Trim());
            Clear();
            Write("> Please Enter a Name: ");
            string userName = ReadLine().Trim();
            var userCharacter = CharacterFactory.GetCharacter(userChoice, userName);
            WriteLine();
            userCharacter.Attact();
            ReadKey();
        }

    }
}

