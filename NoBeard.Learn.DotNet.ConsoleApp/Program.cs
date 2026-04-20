using NoBeard.Learn.DotNet.ClassLibrary.Models;

var outfit = new List<ClothingItem>();

while (true)
{
    Console.WriteLine("\nChoose item type:");
    Console.WriteLine("1 = Shirt");
    Console.WriteLine("2 = Pants");
    Console.WriteLine("3 = Shoes");
    Console.WriteLine("0 = Finish");

    ConsoleKeyInfo key = Console.ReadKey(true);
    char choice = key.KeyChar;

    if (choice == '0') break;

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    switch (choice)
    {
        case '1':
            Console.Write("Size (S/M/L/XL): ");
            string size = Console.ReadLine();
            outfit.Add(new Shirt(name, price, size));
            break;

        case '2':
            Console.Write("Waist size: ");
            int waist = int.Parse(Console.ReadLine());
            outfit.Add(new Pants(name, price, waist));
            break;

        case '3':
            Console.Write("Shoe size: ");
            int shoeSize = int.Parse(Console.ReadLine());
            outfit.Add(new Shoes(name, price, shoeSize));
            break;

        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}

Console.WriteLine("\n--- SELECTED OUTFIT ---\n");

decimal total = 0;
foreach (var item in outfit)
{
    item.Print();
    total += item.Price;
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"\nTOTAL PRICE: {total} EUR");
Console.ResetColor();
