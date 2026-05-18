namespace NoBeard.Learn.DotNet.ConsoleApp;

internal class Program
{
    public delegate void HelloWorldDelegate(string message);

    static void Main(string[] args)
    {
        #region Anonimni tipovi

        string ime = "Pero";
        var id = 10;

        var polaznik = new { Id = 10, Ime = "Pero" };

        Console.WriteLine($"Sifra: {polaznik.Id}, Ime: {polaznik.Ime}");

        var polaznik2 = new { id, ime };

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

        #endregion

        #region Anonimne metode

        //HelloWorldDelegate delegat = new HelloWorldDelegate(PozivnaMetoda);
        //HelloWorldDelegate delegat = PozivnaMetoda;

        //void PozivnaMetoda(string message)
        //{
        //    Console.WriteLine($"{message}");    
        //}

        HelloWorldDelegate delegat = delegate (string message)
        {
            Console.WriteLine($"Hello world, {message}!");
        };

        //delegat.Invoke("Pero");
        delegat("Pero");

        ObaviRadnju(delegat);

        var metoda = (string message) =>
        {
            Console.WriteLine($"Hello world from {ime}: {message}!");
        };

        var osobe = new List<Osoba>()
        { 
            new Osoba(1, "Pero"),
            new Osoba(2, "Maja"),
        };

        osobe.ForEach(new Action<Osoba>(IzlistajOsobu));
        osobe.ForEach(clan => Console.WriteLine($"Hello world from {clan.Naziv}!"));

        //Func<Osoba, bool> uvjet = (Osoba osoba) => { return osoba.Sifra > 10; };
        Func<Osoba, bool> uvjet = _ => _.Sifra > 10;

        osobe.Where(osoba => osoba.Sifra > 10);
        osobe.Where(uvjet);

        void odavdeDoBeskraja(int i)
        {
            odavdeDoBeskraja(i);
            Console.WriteLine($"Prolaz {i}. puta");
            i++;
        }
        odavdeDoBeskraja(1);

        #endregion
    }

    private static void IzlistajOsobu(Osoba clan)
    {
        Console.WriteLine($"Hello world from {clan.Naziv}!");
    }

    private static void ObaviRadnju(HelloWorldDelegate delegat)
    {
        delegat.Invoke("Maja");
    }
}

public class Osoba
{
    public int Sifra { get; set; }

    public string Naziv { get; set; }

    public Osoba(int sifra, string naziv)
    {
        Sifra = sifra;
        Naziv = naziv;
    }
}



