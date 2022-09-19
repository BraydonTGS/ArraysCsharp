using System;
using static System.Console;
namespace ArraysCSharp
{
    public class Character
    {
        private string Name;
        private string Type;
        private ConsoleColor Color;
        private int Level;

        public Character(string charName, string charType, ConsoleColor charColor, int charLevel)
        {
            Name = charName;
            Type = charType;
            Color = charColor;
            Level = charLevel;
        }

        public void DisplayCharacter()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine($"\n> {Name}");
            WriteLine($"> {Level}");
            WriteLine($"> {Type}");
            ForegroundColor = prevColor;
        }
    }
}

