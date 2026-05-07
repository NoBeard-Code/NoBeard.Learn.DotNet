namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Racun 
{
    //public delegate void EventHandler(object? sender, EventArgs e);

    public event EventHandler<double> StanjePromjenjeno;

    private double _stanje;

    public double Stanje
    {
        get
        {
            return _stanje;
        }
        private set
        {
            _stanje = value;
            StanjePromjenjeno?.Invoke(this, value);
        }
    }

    public void Uplati(double iznos)
    {
        Stanje += iznos;
        //StanjePromjenjeno.Invoke(this, Stanje);
    }

    public void Isplati(double iznos)
    {
        Stanje -= iznos;
    }

    public void IsplatiSve()
    {
        Stanje = 0;
    }
}
