using System;

class Program
{
    // This method prompts the user for a valid input (integer)
    static int GetValidInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            // Read user input and try to parse it as an integer
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.WriteLine("Invalid input! Try again.");
        }
    }

    // Main method where the program starts executing
    static void Main()
    {
        bool keepGoing = true;

        // Loop to ask for input and continue based on the user's choice
        while (keepGoing)
        {
            int row = GetValidInput("Target row?: ");
            int column = GetValidInput("Target column?: ");
            Console.WriteLine($"Deploy to position {row}, {column}!");

            // Ask the user if they want to continue
            Console.WriteLine("Let's go for another spot?! Y/N");
            keepGoing = Console.ReadLine().ToUpper() == "Y"; // Update keepGoing based on user input
        }

        Console.WriteLine("Tally-ho!"); // Display a goodbye message
        Console.ReadKey();  // Wait for a key press before closing the console
    }
}
