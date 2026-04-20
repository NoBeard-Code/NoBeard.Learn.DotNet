namespace NoBeard.Learn.DotNet.ConsoleApp.Interfaces;

public interface ISredstvoPlacanja : IPrintable
{
    double Stanje { get; }

    void Uplati(double iznos);

    void Isplati(double iznos);
}
