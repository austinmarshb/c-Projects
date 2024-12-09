class Program
{
    static void Main()
    {
        var soup = (Seasoning: Seasoning.Spicy, Ingredient: MainIngredient.Mushrooms, SoupType: TypeOfSoup.Soup);

        Console.WriteLine("What type of meal would you like? soup, stew or gumbo?");
        string soupChoice = Console.ReadLine().ToLower();

        // Use a switch statement for selecting the soup type
        soup = soupChoice switch
        {
            "soup" => (soup.Item1, soup.Item2, TypeOfSoup.Soup),
            "stew" => (soup.Item1, soup.Item2, TypeOfSoup.Stew),
            "gumbo" => (soup.Item1, soup.Item2, TypeOfSoup.Gumbo),
            _ => (soup.Item1, soup.Item2, TypeOfSoup.Soup) // Default to Soup if invalid input
        };

        Console.WriteLine($"Great, let's start making some {soup.SoupType}! What should be the main ingredient? mushrooms, chicken, carrots or potatoes?");
        string ingredientChoice = Console.ReadLine().ToLower();

        // Use a switch statement for selecting the ingredient
        soup = ingredientChoice switch
        {
            "mushrooms" => (soup.Item1, MainIngredient.Mushrooms, soup.SoupType),
            "chicken" => (soup.Item1, MainIngredient.Chicken, soup.SoupType),
            "carrots" => (soup.Item1, MainIngredient.Carrots, soup.SoupType),
            "potatoes" => (soup.Item1, MainIngredient.Potatoes, soup.SoupType),
            _ => (soup.Item1, MainIngredient.Mushrooms, soup.SoupType) // Default to Mushrooms
        };

        Console.WriteLine($"Great, {soup.SoupType} with {soup.Ingredient}, and for the seasoning. spicy, salty or sweet?");
        string seasoningChoice = Console.ReadLine().ToLower();

        // Use a switch statement for selecting the seasoning
        soup = seasoningChoice switch
        {
            "spicy" => (Seasoning.Spicy, soup.Ingredient, soup.SoupType),
            "salty" => (Seasoning.Salty, soup.Ingredient, soup.SoupType),
            "sweet" => (Seasoning.Sweet, soup.Ingredient, soup.SoupType),
            _ => (Seasoning.Spicy, soup.Ingredient, soup.SoupType) // Default to Spicy
        };

        Console.WriteLine($"You're making a {soup.SoupType} with {soup.Ingredient} and {soup.Item1} seasoning!");
        Console.ReadKey();
    }

    // Enum definitions
    enum TypeOfSoup
    {
        Soup,
        Stew,
        Gumbo
    }

    enum MainIngredient
    {
        Mushrooms,
        Chicken,
        Carrots,
        Potatoes
    }

    enum Seasoning
    {
        Spicy,
        Salty,
        Sweet
    }
}
