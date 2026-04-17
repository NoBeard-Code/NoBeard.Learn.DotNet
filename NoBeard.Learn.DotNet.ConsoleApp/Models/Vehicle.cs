namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Vehicle
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public string GetInfo()
    {
        return $"{Brand} {Model}";
    }
}
