Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your characters name: ");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character type: Warrior, Wizard, Archer");
string characterType = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {characterType}, find yourself at the edge of a dark forest.\n" +
    $"Shall you enter or camp outside? (Enter/Camp)");

string choice1 = Console.ReadLine().ToLower();

if (choice1 == "enter")
{
    Console.WriteLine("You bravely enter the forest.");
}
else if (choice1 == "camp")
{
    Console.WriteLine("You decide to spend the night on the outskirts and save your strength.");
}

bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road, do you go left or right? (Left/Right)");
    string direction = Console.ReadLine().ToLower();
    if (direction == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild and dangerous beast!\n" +
            "Do you want to fight or flee? (Fight/Flee)");
        string fightChoice = Console.ReadLine().ToLower();
        if (fightChoice == "fight")
        {
            Console.WriteLine("The beast was too strong and you died.");
            gameContinues = false;
        }
        else if (fightChoice == "flee")
        {
            Console.WriteLine("You run away and live to fight another day!");
            gameContinues = false;
        }
    }
}
Console.ReadKey();
