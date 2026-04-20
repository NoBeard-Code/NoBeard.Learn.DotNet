using NoBeard.Learn.DotNet.ConsoleApp.Interfaces;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public sealed class TekuciRacun : BankovniRacun, IBezgotovinskoPlacanje
{
    public double DopustenoPrekoracenje { get; init; }

    public TekuciRacun(long broj, double stanje) : base(broj, "tekući račun", stanje)
    {
        base.Nasljedno = "";
        DopustenoPrekoracenje = 1000.00;
    }

    public override void IzvrsiProcesPlacanja()
    {
        throw new NotImplementedException();
    }
}

//public class HakiraniTekuciRacun : TekuciRacun
//{
//    public HakiraniTekuciRacun(long broj, double stanje) : base(broj, 1000000)
//    {
        
//    }
//}