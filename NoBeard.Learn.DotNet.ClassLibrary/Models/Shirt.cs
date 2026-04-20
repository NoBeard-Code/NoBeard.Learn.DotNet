using NoBeard.Learn.DotNet.ClassLibrary.Enumerations;

namespace NoBeard.Learn.DotNet.ClassLibrary.Models;

public class Shirt : ClothingItem
{
    public string Size { get; set; }

    public Shirt(string name, decimal price, string size)
        : base(name, price, ClothingType.Shirt)
    {
        Size = size;
    }

    public override void Print()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Shirt: {Name} ({Size}) - {Price} EUR");
        Console.ResetColor();
    }
}
