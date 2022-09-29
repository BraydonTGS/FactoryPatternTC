using System;
using static System.Console;
namespace FactoryPatternTC
{
    public static class CharacterFactory
    {

        public static ICharacter GetCharacter(int choice, string name)
        {
            switch (choice)
            {
                case 1:
                    return new Warrior(name);
                case 2:
                    return new Mage(name);
                case 3:
                    return new Thief(name);
                default:
                    return new Warrior(name);

            }

        }
    }

}