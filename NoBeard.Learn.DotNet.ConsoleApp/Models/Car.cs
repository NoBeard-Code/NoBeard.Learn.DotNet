namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public string GetCarInfo()
    {
        return $"{GetInfo()} {NumberOfDoors}";
    }
}

internal class PersonalCar : Car
{

}

