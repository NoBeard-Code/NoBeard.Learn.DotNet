using NoBeard.Learn.DotNet.ClassLibrary.Enumerations;
using NoBeard.Learn.DotNet.ClassLibrary.Interfaces;

namespace NoBeard.Learn.DotNet.ClassLibrary.Models;

public abstract class ClothingItem : IClothingItem
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Description { get; set; }

    public ClothingType Type { get; set; }

    public ClothingItem(string name, decimal price, ClothingType type)
    {
        Name = name;
        Price = price;
        Type = type;
    }

    public virtual void Print()
    {
        Console.WriteLine($"{Type}: {Name} - {Price} EUR");
    }
}
