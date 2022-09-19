using System;
using static System.Console;
namespace ArraysCSharp
{
    public class PartySystem
    {

        Character[] MyTeam = new Character[3];
        public PartySystem()
        {
            // Construct the team //
            MyTeam[0] = new Character("Pikachu", "Electirc", ConsoleColor.Yellow, 10);
            MyTeam[1] = new Character("Charizard", "Fire", ConsoleColor.Red, 40);
            MyTeam[2] = new Character("Bulbasaur", "Grass", ConsoleColor.Green, 12);
        }

        public void Run()
        {
            // Display the Team //
            WriteLine("===> My Team <===");
            foreach (var pokemon in MyTeam)
            {
                pokemon.DisplayCharacter();
            }

        }
    }
}

