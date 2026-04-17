namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Bicycle : Vehicle
{
    public bool HasBell { get; set; }

    public string GetBicycleInfo()
    {
        return $"{GetInfo()} {HasBell}"; 
    }
}
