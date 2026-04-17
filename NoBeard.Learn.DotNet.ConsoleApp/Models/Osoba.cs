namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Osoba
{
    private string _ime = string.Empty;
    private string _prezime = string.Empty;
    private DateTime _datumRodjenja;

    public string Ime
    {
        get { return _ime; }
        set { _ime = value; }
    }

    public string Prezime
    {
        get { return _prezime; }
        set { _prezime = value; }
    }

    //public string Ime { get; set; }

    //public string Prezime { get; set; }

    public string PunoIme
    {
        get { return $"{_ime} {_prezime}"; }
    }

    public int Starost
    {
        get { return IzracunajStarost(); }
    }
    
    public DateTime DatumRodjenja // TODO: promijeni u DateOnly tip podatka
    {
        get { return _datumRodjenja; }
        set { _datumRodjenja = value; }
    }

    public static int RedniBroj { get; private set; }

    internal List<BankovniRacun> Racuni { get; set; } = []; // = new BankovniRacun();

    public Osoba()
    {
        //Racun = new BankovniRacun();
        RedniBroj++;
    }

    ~Osoba()
    {
        RedniBroj--;
    }

    private int IzracunajStarost()
    {
        return (DateTime.Today.Year - _datumRodjenja.Year);
    }
}
