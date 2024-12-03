//create boolean variable for do-while loop to keep program running until user exits
bool inMenu = true;

//create list with default starting items
var toDoList = new List<string> { "Feed Ocho", "Buy socks", "Do laundry" };

//welcome message
Console.WriteLine("Hello, welcome to your shitty TODO list application, what would you like to do?");

//start of loop
do
{
    //initialize menu options
    Console.WriteLine("........................");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit the application");
    Console.WriteLine("........................");

    //read user input and change to uppercase for processing
    var userInput = Console.ReadLine().ToUpper();

    //switch statement for program logic
    switch (userInput)
    {
        //see TODO list
        case "S":
            //if its empty
            if (toDoList.Count == 0)
            {
                Console.WriteLine("~~~~~~~~~~~~~ No TODOs yet! ~~~~~~~~~~~~~");
            }
            //otherwise show items
            else
            {
                Console.WriteLine("~~~~~~~~~~~~~ Here are your TODOs ~~~~~~~~~~~~~");
                //for loop iterates through list to show indexes and contents
                for (var i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + toDoList[i]);
                }
            }
            break;
        case "A":

            //add item logic start
            Console.WriteLine("~~~~~~~~~~~~~ What would you like to add? ~~~~~~~~~~~~~");
            var userAddItem = Console.ReadLine();

            //check for valid input
            if (string.IsNullOrWhiteSpace(userAddItem))
            {
                Console.WriteLine("~~~~~~~~~~~~~ Please enter a new TODO! ~~~~~~~~~~~~~");
            }
            //check to see if item is already on the list
            else if (toDoList.Contains(userAddItem))
            {
                Console.WriteLine("~~~~~~~~~~~~~ This item already exists! Please enter a unique TODO ~~~~~~~~~~~~~");
            }
            //if input is valid and item is unique, add it and show its index value
            else
            {
                toDoList.Add(userAddItem);
                Console.WriteLine($"~~~~~~~~~~~~~ {toDoList.Count}. '{userAddItem}' has been added to list! ~~~~~~~~~~~~~");
            }
            break;
        case "R":
            //remove logic start
            Console.WriteLine("~~~~~~~~~~~~~ What would you like to remove? ~~~~~~~~~~~~~ ");
            //show items, same as add item logic loop
            for (var i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + toDoList[i]);
            }
            var userRemoveItem = Console.ReadLine();
            //parse entry to integer
            if (int.TryParse(userRemoveItem, out int index))
            {
                //validate integer input is in range of list
                if (index >= 0 && index <= toDoList.Count)
                {
                    //if successful show removed item contents and index, list items are then reindexed
                    string removedItem = toDoList[index - 1];
                    Console.WriteLine($"~~~~~~~~~~~~~ {index}. '{removedItem}' removed! ~~~~~~~~~~~~~");
                    toDoList.RemoveAt(index - 1);
                }
                //if index is out of range
                else
                {
                    Console.WriteLine(" ~~~~~~~~~~~~~ That number is out of range! Try again. ~~~~~~~~~~~~~");
                }
            }
            break;
        case "E":
            //exiting app messages
            Console.WriteLine("~~~~~~~~~~~~~ Press any key to exit, cya! ~~~~~~~~~~~~~");
            Console.ReadKey();
            return;
        default:
            //default case for invalid beginning entries
            Console.WriteLine("~~~~~~~~~~~~~ Invalid choice! ~~~~~~~~~~~~~");
            break;
    }
    //end of while loop
} while (inMenu);
