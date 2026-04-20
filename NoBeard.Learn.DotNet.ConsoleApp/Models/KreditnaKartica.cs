using NoBeard.Learn.DotNet.ConsoleApp.Interfaces;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public class KreditnaKartica : ISredstvoPlacanja, IBezgotovinskoPlacanje
{
    public double Stanje { get; private set; }

    public string BrojKartice { get; set; }

    public KreditnaKartica(string broj, double stanje)
    {
        BrojKartice = broj;
        Stanje = stanje;
    }

    public void Isplati(double iznos)
    {
        Stanje -= iznos;
    }

    public void Uplati(double iznos)
    {
        Stanje += iznos;
    }

    public void Print()
    {
        Console.WriteLine($"Broj kartice: {BrojKartice}");

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

        Console.WriteLine("Stanje kartice: {0:0.00} EUR", Stanje);

        Console.ResetColor();
    }
}
