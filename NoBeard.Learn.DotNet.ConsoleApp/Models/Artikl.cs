namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Artikl 
{
    public int Sifra { get; set; }

    public string Naziv { get; set; }

    public int Vrsta { get; set; }

    public long Barkod { get; set; }

    public int StanjeNaSkladistu { get; set; }

    public override string ToString()
    {
        return $"Sifra: {Sifra}, Naziv: {Naziv}, Barkod: {Barkod}, Stanje: {StanjeNaSkladistu}, Vrsta: {Vrsta}";
    }
}
