
var ime = "Pero";
var id = 10;

var polaznik = new { Id = 10, Ime = "Pero" };

Console.WriteLine($"Sifra: {polaznik.Id}, Ime: {polaznik.Ime}");

// polaznik.Id = 20;

var osoba = new
{
    Sifra = 100,
    Ime = "Pero",
    Prezime = "Perić",
    GodinaRodjenja = 2026,
    DatumUpisa = DateTime.Today,
    Racun = new
    {
        Sifra = 1000,
        Naziv = "Superbanka",
        Stanje = 100.00F
    }
};

Console.WriteLine($"Osoba, Ime: {osoba.Ime}, Račun, Naziv: {osoba.Racun.Naziv}");

var polaznici = new[]
{
    new { Id = 10, Name = "Pero" },
    new { Id = 20, Name = "Anja" },
    new { Id = 30, Name = "Maja" },
    new { Id = 40, Name = "Marko" }
};

var zadnji = polaznici.Last();
var pretraga = polaznici.Where(_ => _.Id > 10).ToList();

pretraga.ForEach(x => Console.WriteLine($"Polaznik: šifra: {x.Id}, ime: {x.Name}"));
    



