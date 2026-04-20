using NoBeard.Learn.DotNet.ConsoleApp.Interfaces;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public abstract class BankovniRacun : ISredstvoPlacanja, IBezgotovinskoPlacanje
{
    public long Broj { get; set; }

    public double Stanje { get; set; }

    public string Vrsta { get; set; }

    protected string Nasljedno { get; set; } = string.Empty;

    public BankovniRacun(long broj, string vrsta, double stanje)
    {
        Nasljedno = string.Empty;

        Broj = broj;
        Stanje = stanje;
        Vrsta = vrsta;
    }

    public void Uplati(double iznos)
    {
        Stanje += iznos;
    }

    public void Isplati(double iznos)
    {
        Stanje -= iznos;

        if (Stanje < 0) Console.Beep();
    }

    public abstract void IzvrsiProcesPlacanja();

    public void IspisiPodatke()
    {
        Console.WriteLine($"Broj računa: {Broj}");
        Console.WriteLine($"Vrsta računa: {Vrsta}");

        if (Stanje > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (Stanje < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        Console.WriteLine("Stanje računa: {0:0.00} EUR", Stanje);

        Console.ResetColor();
    }

    public void Print()
    {
        Console.WriteLine($"Broj računa: {Broj}");
        Console.WriteLine($"Vrsta računa: {Vrsta}");

        if (Stanje > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (Stanje < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        Console.WriteLine("Stanje računa: {0:0.00} EUR", Stanje);

        Console.ResetColor();
    }
}
