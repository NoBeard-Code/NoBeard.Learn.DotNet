namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class FazaEventArgs : EventArgs
{
    public byte RedniBroj { get; init; }

    public bool Uspjesno { get; set; } = true;

    public DateTime VrijemePocetka { get; set; }

    public DateTime VrijemeZavrsetka { get; set; }

    public FazaEventArgs(byte redniBroj)
    {
        RedniBroj = redniBroj;
    }
}
