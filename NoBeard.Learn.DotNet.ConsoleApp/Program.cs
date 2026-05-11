var lista = new List<string>
{
    "Pero",
    "Maja",
    "Marko"
};

//var rezultat = lista.FindAll((clan) => { return clan == "Pero"; });
//var rezultat = lista.FindAll(x => { return x == "Pero"; });
//var rezultat = lista.FindAll(x => x == "Pero");
var rezultat = lista.FindAll(x => x.Equals("Pero"));

string imena = string.Empty;

foreach (var ime in lista)
{
    imena += ime; // = imena + ime;
}

lista.ForEach(ime => imena += ime);

//public delegate void Akcija();
//Akcija akcija = new Akcija(IzvrsiAkciju);
//private void IzvrsiAkciju()
//{
//Console.WriteLine("Izvrši akciju")
//}

Action akcija = () => Console.WriteLine("Izvrši akciju");
akcija.Invoke();

Action<string> ispisi = (ime) => Console.WriteLine("Ime je: {0}", ime);
ispisi("Pero");

Func<string, string> pozdravi = (ime) => { return $"Pozdrav, {ime}!"; };
Console.WriteLine(pozdravi.Invoke("Milan"));

Func<string, int> delegat = delegate (string ulaz)
{
    return 1;
};
var broj = delegat(string.Empty);



var osobe = new List<Osoba>
{
    new Osoba(1, "Pero"),
    new Osoba(2, "Marko"),
    new Osoba(3, "Maja")
};

osobe.ForEach((osoba) => { Console.WriteLine(osoba.Sifra); });
osobe.ForEach(_ => Console.WriteLine(_.Sifra));

var projekcija = osobe.Select(x => { return x.Ime; });

Console.ReadLine();

public class Osoba
{
    public int Sifra { get; set; }

    public string Ime { get; init; }

    public Osoba(int sifra, string ime)
    {
        Sifra = sifra;
        Ime = ime;
    }
}


