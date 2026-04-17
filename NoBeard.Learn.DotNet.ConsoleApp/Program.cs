using NoBeard.Learn.DotNet.ConsoleApp.Models;

namespace NoBeard.Learn.DotNet.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        // OSNOVNI DIO (klase su ispod):

        /*      

        Jabuka jabuka1 = new Jabuka();
        jabuka1.IspisiSvojstva();

        //jabuka1.Boja = "žuta";
        jabuka1.TezinaG += 20;

        jabuka1.IspisiSvojstva();

        jabuka1 = null;

        Jabuka jabuka2 = new Jabuka("crvena", 75);
        jabuka2.Kupi();

        Jabuka jabuka3 = new Jabuka();
        jabuka3.BioUzgoj = true;
        jabuka3.Kupi();

        Console.Clear();

        var racun = new BankovniRacun();
        racun.Info();
        Console.ReadLine();

        racun.Uplati(500.00);
        racun.Info();
        Console.ReadLine();

        racun.Isplati(1200.00);
        racun.Info();
        Console.ReadLine();

        */

        // IZDVOJENE KLASE:

        Jabuka jabuka1 = new Jabuka();
        Console.Write(jabuka1.Boja);
        jabuka1.TezinaG = 20.00;
        jabuka1.IspisiSvojstva();

        Jabuka jabuka2 = new Jabuka("crvena", 75, false);
        jabuka2.IspisiSvojstva();

        Console.Clear();

        var racun1 = new BankovniRacun();
        racun1.Kreiraj(1234);
        racun1.Ispisi();
        racun1.Uplati(500.00);
        racun1.Isplati(250.00);
        racun1.Ispisi();

        var racun2 = new BankovniRacun(2345, vrsta: "žiro", stanje: 300.00);
        //racun2.Kreiraj(2345, vrsta: "žiro", stanje: 300.00);
        racun2.Ispisi();
        racun2.Isplati(400.00);
        racun2.Ispisi();

        var osoba1 = new Osoba
        {
            Ime = "Pero",
            Prezime = "Perić",
            DatumRodjenja = new DateTime(1994, 01, 01)
        };

        Console.WriteLine(Osoba.RedniBroj);
        MyConsole.WriteLine(osoba1.PunoIme);
        Console.WriteLine(osoba1.Starost);
        //osoba1.Racun.Ispisi();
        MyConsole.WriteLine($"Broj računa: {osoba1.Racuni.Count}");

        Osoba osoba2 = new()
        {
            Ime = "Mara",
            Prezime = "Marić",
            DatumRodjenja = new DateTime(1996, 01, 07)
        };

        Console.WriteLine(Osoba.RedniBroj);
        MyConsole.WriteLine(osoba2.PunoIme);
        Console.WriteLine(osoba2.Starost);

        var medijan = Calc.Median([10.0, 20, 50]);

        Connection.Instance.Open();

        var program = new ProgramObrazovanja("ASP.NET Developer", "OL-OASP_DEV_H-02/24");
        program.Polaznici.AddRange(new[] { osoba1, osoba2, osoba1, osoba2, osoba2 });
        program.ListaModula.AddRange(new[] { new Modul(1, "Uvod u C#"), new Modul(2, "Uvod u baze podataka") });

        var brojPolaznika = program.Polaznici.Count;
        var zadnjiModul = program.ListaModula.Last();
    }
}

/*
class Jabuka
{
    // privatne varijable
    private string _boja;
    private double _tezinaG;
    private bool _bioUzgoj;

    #region svojstva

    //public string Boja;

    public string Boja
    {
        get { return _boja; }
    }

    //public double TezinaG;

    public double TezinaG
    {
        get { return _tezinaG; }
        set { _tezinaG = value; }
    }

    //public bool BioUzgoj;
    public bool BioUzgoj
    {
        set { _bioUzgoj = value; }
    }

    public string Oblik { get; set; }

    #endregion

    // konstruktori
    public Jabuka()
    {
        Console.WriteLine("Konstrukcija objekta.");

        _boja = "zelena";
        TezinaG = 80;
    }

    public Jabuka(string boja, double tezinaG)
    {
        _boja = boja;
        TezinaG = tezinaG;
    }

    #region metode

    public void Kupi()
    {
        Console.WriteLine("Metoda Kupi je pozvana.");
    }

    public void Uberi()
    {
    }

    public void IspisiSvojstva()
    {
        Console.WriteLine($"Boja: {_boja}");
        Console.WriteLine($"BioUzgoj: {_bioUzgoj}");
        Console.WriteLine($"Težina (u gramima): {_tezinaG}");
    }

    #endregion

    // privatne metode
}

public class BankovniRacun
{
    private long _broj;
    private double _stanje;
    private string _vrsta;

    public BankovniRacun()
    {
        _broj = 123456789;
        _stanje = 0.0;
        _vrsta = "žiro";
    }

    public void Uplati(double iznos)
    {
        _stanje += iznos;
    }

    public void Isplati(double iznos)
    {
        _stanje -= iznos;

        if (_stanje < 0) Console.Beep();
    }

    public void Info()
    {
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

        Console.WriteLine("Stanje računa: {0:0.00} EUR", _stanje);

        Console.ResetColor();
    }
}

*/