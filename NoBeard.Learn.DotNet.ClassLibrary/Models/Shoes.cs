using NoBeard.Learn.DotNet.ClassLibrary.Enumerations;

namespace NoBeard.Learn.DotNet.ClassLibrary.Models;

public class Shoes : ClothingItem
{
    public int Size { get; set; }

    public Shoes(string name, decimal price, int size)
        : base(name, price, ClothingType.Shoes)
    {
        Size = size;
    }

    public override void Print()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Shoes: {Name} (Size {Size}) - {Price} EUR");
        Console.ResetColor();
    }
}
