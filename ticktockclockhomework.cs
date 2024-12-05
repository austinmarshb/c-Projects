class Program
{
    static void Main()
    {
        bool clockRunning = true;
        while (clockRunning)
        {

            Console.WriteLine("Provide a number: ");
            string userInput = Console.ReadLine();
            int clockValue = Convert.ToInt32(userInput);
            if (clockValue % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
            Console.WriteLine("Perform another input? Y/N");
            clockRunning = Console.ReadLine().ToUpper() == "Y";
        }
        Console.WriteLine("You fixed the clock! Press any key to exit.");
        Console.ReadKey(true);
    }
}
