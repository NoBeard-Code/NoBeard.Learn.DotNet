using NoBeard.Learn.DotNet.ClassLibrary.Enumerations;

namespace NoBeard.Learn.DotNet.ClassLibrary.Models;

public class Pants : ClothingItem
{
    public int Waist { get; set; }

    public Pants(string name, decimal price, int waist)
        : base(name, price, ClothingType.Pants)
    {
        Waist = waist;
    }

    public override void Print()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Pants: {Name} (Waist {Waist}) - {Price} EUR");
        Console.ResetColor();
    }
}