using NoBeard.Learn.DotNet.ConsoleApp.Exceptions;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

/// <summary>
/// Represents a vehicle with registration information, damage status, and make and model details.
/// </summary>
internal class Vozilo
{
    public DateTime? DatumRegistracije { get; set; }

    public bool Osteceno { get; set; }

    public string Marka { get; set; }

    public string Model { get; set; }

    public Vozilo(string marka, string model, bool osteceno = false)
    {
        Marka = marka;
        Model = model;
        Osteceno = osteceno;
    }

    /// <summary>
    /// Metoda za registraciju vozila.
    /// </summary>
    /// <exception cref="VoziloException"></exception>
    internal void RegistrirajVozilo()
    {
        if (Osteceno)
        {
            throw new VoziloException("Vozilo je osteceno!", this);
        }

        DatumRegistracije = DateTime.Now;
    }

    internal void Popravi()
    {
        if (!Osteceno)
        {
            //return;
            throw new VoziloException("Vozilo nije osteceno!", this);
        }

        // TODO: postupak popravljanja
        ZamijeniUlje();
    }

    private void ZamijeniUlje()
    {
        try
        {
            int b = 0;
            int a = 50 / b;
        }
        catch (DivideByZeroException ex)
        {
            throw new VoziloException("Zamjena ulja nije uspjela", this, ex);
        }
    }
}
