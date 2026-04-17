namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Jabuka
{    
    // privatne varijable
    private string _boja;
    private double _tezinaG;
    private bool _bioUzgoj;

    #region Svojstva

    internal string Boja
    {
        get { return _boja; }
    }

    public double TezinaG
    {
        get { return _tezinaG; }
        set { _tezinaG = value; }
    }

    public bool BioUzgoj
    {
        set { _bioUzgoj = value; }
    }

    public string Oblik { get; set; }

    #endregion

    public Jabuka()
    {
        Console.WriteLine("Inicijalizacija objekta");

        _boja = "zelena";
        _tezinaG = 80.00;
        _bioUzgoj = true;
    }

    public Jabuka(string boja, double tezinaG, bool bioUzgoj)
    {
        _boja = boja;
        _tezinaG = tezinaG;
        _bioUzgoj = bioUzgoj;
    }

    // metode

    internal void IspisiSvojstva()
    {
        Console.WriteLine($"Boja: {_boja}");
        Console.WriteLine($"Težina (u g): {_tezinaG}");
        Console.WriteLine($"Da li je bio uzgoj: {_bioUzgoj}");
    }

    public void Kupi()
    {
        // poziv priv. metoda
        // čitanje priv. var
        // setiranje priv. var
    }

    public void Uberi()
    {

    }

    public void Izvazi()
    {

    }

    // privatne metode

    ~Jabuka()
    {

    }
}
