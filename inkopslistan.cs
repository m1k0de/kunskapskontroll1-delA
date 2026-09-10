List<string> names = new List<string>();

List<int> prices = new List<int>();

while (true)
{
    Console.WriteLine("\nINKÖPSLISTA");
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
    }

    Console.Write("\nSkriv in varunamn: ");
    string inputName = Console.ReadLine();

    Console.Write("Skriv in pris i heltal: ");
    int inputPrice = int.Parse(Console.ReadLine());

    names.Add(inputName);
    prices.Add(inputPrice);
}