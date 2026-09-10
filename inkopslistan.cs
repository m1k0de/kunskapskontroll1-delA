List<string> names = new List<string>();

List<int> prices = new List<int>();

while (true)
{
    Console.WriteLine("\nINKÖPSLISTA");
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
    }

    int totalPrice = 0;
    foreach (int price in prices)
    {
        totalPrice += price;
    }
    Console.WriteLine($"\nTotalbelopp: {totalPrice} kr");

    if (names.Count > 0)
    {
        int highestPrice = prices[0];
        string mostExpensiveName = names[0];
        
        for (int i = 1; i < prices.Count; i++)
        {
            if (prices[i] > highestPrice)
            {
                highestPrice = prices[i];
                mostExpensiveName = names[i];
            }
        }

        Console.WriteLine($"\nDyrast just nu är: {mostExpensiveName} {highestPrice} kr");
    }

    Console.Write("\nSkriv in varunamn (eller varans nummer för att ta bort): ");
    string inputName = Console.ReadLine();

    if (int.TryParse(inputName, out int removeIndex))
    {
        int actualIndex = removeIndex - 1;

        if (actualIndex >= 0 && actualIndex < names.Count)
        {
            names.RemoveAt(actualIndex);
            prices.RemoveAt(actualIndex);
            Console.WriteLine("Varan har tagits bort!");
        }
        else
        {
            Console.WriteLine("Ogiltigt nummer.");
        }
    }

    else
    {
        Console.Write("Skriv in pris i heltal: ");
        int inputPrice = int.Parse(Console.ReadLine());
        
        names.Add(inputName);
        prices.Add(inputPrice);
    }

}