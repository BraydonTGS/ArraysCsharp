using static System.Console;

Title = "Array Practice";

WriteLine("==> Array Practice <==");
// Arrays: 0 Based, Fixed Type, Fixed Size //

// Scores // 
int[] scores = new int[3];
scores[0] = 10;
scores[1] = 12;
scores[2] = 11;

foreach (var item in scores)
{
    WriteLine($"\nThe score is {item}");

}
WriteLine($"\nThere are {scores.Length} items");

// Inventory // 
string[] inventory = { "potion", "stick", "ring", "shield", "torch" };

for (int i = 0; i < inventory.Length; i++)
{
    WriteLine($"\n{inventory[i]}");
}

bool[] answers = { true, true, false };

// Monsters[] monster = new Monster[5]; //

WriteLine("\nPress any key to exit");

ReadKey();