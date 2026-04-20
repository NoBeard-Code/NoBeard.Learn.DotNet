namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class BankovniRacun
{
    private long _broj;
    private double _stanje;
    private string _vrsta;

    public BankovniRacun()
    {
        this._stanje = 0.0;
        _vrsta = "tekući";
    }

    public BankovniRacun(long broj, double stanje = 0.0, string vrsta = "tekući")
    {
        Kreiraj(broj, stanje, vrsta);
    }

    public void Kreiraj(long broj, double stanje = 0.0, string vrsta = "tekući")
    {
        _broj = broj;
        _stanje = stanje;
        _vrsta = vrsta;
    }

    public void Uplati(double iznos)
    {
        _stanje += iznos;
    }

    public void Isplati(double iznos)
    {
        if (_stanje - iznos >= 0)
        {
            _stanje -= iznos;
        }
        else
        {
            _stanje = 0;
            Console.Beep();
        }

        //_stanje -= iznos;
    }

    public void Ispisi()
    {
        //Console.Clear();

        Console.WriteLine($"Broj računa: {_broj}");
        Console.WriteLine($"Vrsta računa: {_vrsta}");

        if (_stanje > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (_stanje < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        Console.WriteLine("Stanje računa: {0:0.00} €", _stanje);

        Console.ResetColor();   
    }

}
