using NoBeard.Learn.DotNet.ConsoleApp.Extensions;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public sealed class Racun
{
    public int Sifra { get; set; }

    public string Naziv { get; set; }

    public double Stanje { get; set; }

    public void Uplati(double iznos)
    {
        Stanje += iznos;
        var tekst = $"Novo stanje je: {Stanje}";
        tekst.IspisiTekst();
        //IspisiTekst(tekst);
    }

    private void IspisiTekst(string tekst)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{tekst}");
        Console.ResetColor();
    }
}
