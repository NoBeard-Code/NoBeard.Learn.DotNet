using NoBeard.Learn.DotNet.ConsoleApp.Models;

namespace NoBeard.Learn.DotNet.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        var racun1 = new BankovniRacun();
        racun1.Kreiraj(1234);
        racun1.Ispisi();
        racun1.Uplati(500.00);
        racun1.Isplati(250.00);
        racun1.Ispisi();

        var racun2 = new BankovniRacun(2345, vrsta: "žiro", stanje: 300.00);
        //racun2.Kreiraj(2345, vrsta: "žiro", stanje: 300.00);
        racun2.Ispisi();
        racun2.Isplati(400.00);
        racun2.Ispisi();

        var osoba1 = new Osoba
        {
            Ime = "Pero",
            Prezime = "Perić",
            DatumRodjenja = new DateTime(1994, 01, 01)
        };

        Console.WriteLine(Osoba.RedniBroj);
        Console.WriteLine(osoba1.Starost);
        //osoba1.Racun.Ispisi();

        Osoba osoba2 = new()
        {
            Ime = "Mara",
            Prezime = "Marić",
            DatumRodjenja = new DateTime(1996, 01, 07)
        };

        Console.WriteLine(Osoba.RedniBroj);
        Console.WriteLine(osoba2.Starost);

        var car = new Car();
        car.Brand = "Ford";
        car.Model = "Fiesta";

        Console.Clear();

        var car_ = new Car()
        {
            Brand = "Fiat",
            Model = "Doblo",
            NumberOfDoors = 5
        };

        Console.WriteLine(car.GetCarInfo());

        var bicycle = new Bicycle()
        {
            Brand = "Cube",
            Model = "Curve",
            HasBell = true
        };

        Console.WriteLine(bicycle.GetBicycleInfo());

        var animals = new List<Animal>();

        animals.Add(new Dog() { Name = "Rex" });
        animals.Add(new Cat() { Name = "Matilda" });
        animals.Add(new Dog() { Name = "Boo" });

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name} says: {animal.Speak()}");
        }
    }
}
