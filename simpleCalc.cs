Console.WriteLine("Please choose a number...");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please choose another number...");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Now choose an operation: Add, Subtract, Multiply or Divide...");
string choice = Console.ReadLine().ToLower();

if (choice == "add")
{
    Console.WriteLine($"{firstNumber + secondNumber}");
}
else if (choice == "subtract")
{
    Console.WriteLine($"{firstNumber - secondNumber}");
}
else if (choice == "multiply")
{
    Console.WriteLine($"{firstNumber * secondNumber}");
}
else if (secondNumber != 0 && choice == "divide")
{
    Console.WriteLine($"{firstNumber / secondNumber}");
}
else
{
    Console.WriteLine("Whoops, that's not possible! Sorry.");
}

Console.ReadKey();
