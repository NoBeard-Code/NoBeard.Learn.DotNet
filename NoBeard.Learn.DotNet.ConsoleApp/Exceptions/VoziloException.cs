using NoBeard.Learn.DotNet.ConsoleApp.Models;

namespace NoBeard.Learn.DotNet.ConsoleApp.Exceptions;

internal class VoziloException : Exception //  ApplicationException 
{
    public Vozilo? Vozilo { get; set; }

    public VoziloException(string tekst, Vozilo? vozilo) : base(tekst)
    {
        Vozilo = vozilo;
    }

    public VoziloException(string tekst, Vozilo? vozilo, Exception? originalnaGreska) : base(tekst, originalnaGreska)
    {
        Vozilo = vozilo;
    }
}
