namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public sealed class ZiroRacun : BankovniRacun //, ISredstvoPlacanja
{
    public ZiroRacun(long broj, double stanje) : base(broj, "žiro-račun", stanje)
    {
        
    }

    public override void IzvrsiProcesPlacanja()
    {
        throw new NotImplementedException();
    }
}
