using NoBeard.Learn.DotNet.ClassLibrary.Enumerations;

namespace NoBeard.Learn.DotNet.ClassLibrary.Interfaces;

public interface IClothingItem
{
    string Name { get; set; }

    decimal Price { get; set; }

    string Description { get; set; }

    ClothingType Type { get; set; }
}
