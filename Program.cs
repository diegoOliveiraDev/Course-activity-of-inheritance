using Course.Entities;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int quantity = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantity; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char answer = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (answer == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (answer == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manufactureDate));
    }
    else
    {
        Console.Write("Customs fee: ");
        double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, customsfee));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach(Product product in list)
{
    Console.WriteLine(product);
}