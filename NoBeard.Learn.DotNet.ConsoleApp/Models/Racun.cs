namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

[Serializable]
public class Racun
{
    public int Sifra { get; set; }

    public string Naziv { get; set; }

    public double Stanje { get; set; }

    public Racun()
    {
    }

    //public void Uplata(double iznos)
    //{
    //    if (iznos > 0)
    //    {
    //        Stanje += iznos;
    //    }
    //}

    //public void Isplata(double iznos)
    //{
    //    if (iznos > 0)
    //    {
    //        Stanje -= iznos;
    //    }
    //}

    public override string ToString()
    {
        return $"Racun, sifra: {Sifra}, naziv: {Naziv}";
    }
}
