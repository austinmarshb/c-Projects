class Program
{
    static void Main()
    {
        bool friend = false;
        Console.WriteLine("Welcome to the shop!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine().ToLower();
        if (name == "austin")
        {
            friend = true;
            Console.WriteLine("Alas! My friend! Forgive me and my old eyes!");
            Console.WriteLine("Everything in the shop is 50% for you!");
        }else
        {
            Console.WriteLine("Aye... Thought I recognized you. Alas...");
        }
        Console.WriteLine("The following items are available:");
        bool stillInShopMode = true;
        while (stillInShopMode)
        {
            Console.WriteLine("1 - Rope\n" +
                "2 - Torches\n" +
                "3 - Climbing Equipment\n" +
                "4 - Clean Water\n" +
                "5 - Machete\n" +
                "6 - Canoe\n" +
                "7 - Food Supplies\n" +
                "What item number would you like to see the price of?");
            string userInput = Console.ReadLine();
            int userChoice = Convert.ToInt32(userInput);

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Rope is 5 gold.");
                    else
                        Console.WriteLine("Rope is 10 gold.");
                    break;
                case 2:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Torches are 7.5 gold");
                    else
                        Console.WriteLine("Torches are 15 gold");
                    break;
                case 3:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Climbing equipment is 12 gold");
                    else
                        Console.WriteLine("Climbing equipment is 25 gold");
                    break;
                case 4:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Clean water is 0.5 gold");
                    else
                        Console.WriteLine("Clean water is 1 gold");
                    break;
                case 5:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Machetes are 2.5 gold");
                    else
                        Console.WriteLine("Machetes are 5 gold");
                    break;
                case 6:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Canoes are 100 gold");
                    else
                        Console.WriteLine("Canoes are 200 gold");
                    break;
                case 7:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Food supplies are 0.5 gold.");
                    else
                        Console.WriteLine("Food supplies are 1 gold.");
                    break;
                default:
                    Console.WriteLine("~~~~~~~~~~");
                    if (friend)
                        Console.WriteLine("Huh? I don't think we sell that here...");
                    break;
            }
            Console.WriteLine("Would you like to check another items price?");
            stillInShopMode = Console.ReadLine().ToUpper() == "Y";
        }
        Console.WriteLine("Aye, come back when ye feel the need.");
        Console.ReadKey();
    }
}
