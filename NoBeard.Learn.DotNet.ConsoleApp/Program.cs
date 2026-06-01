using NoBeard.Learn.DotNet.ConsoleApp.Models;
using System.Collections;
using System.Security.Cryptography;

// 1) izvor podataka

string[] gradovi = { "Varaždin", "Zagreb", "Osijek", "Vinkovci", "Slavonski Brod", "Split", "Sisak" };

// 2) izgradnja upita:

// Query sintaksa upita

var query = from grad in gradovi
            where grad.StartsWith("S")
            select grad;

// Selector sintaksa upita

var query2 = gradovi
    .Where(grad => grad.StartsWith("S"));

//List<string> rez = [];
//foreach (var grad in gradovi)
//{
//    if (grad.StartsWith("S"))
//    {
//        rez.Add(grad);
//    }
//}

// 3) izvršavanje upita

foreach (var grad in query)
{
    Console.WriteLine(grad);
}

List<int> brojevi = new() { 1, 2, 3, 5, 6, 8, 9, 10, 11, 12 };

IEnumerable<int> rez = from broj in brojevi
                       where broj > 3 && broj < 10
                       select broj;

// enumerator

var enumerator = query.GetEnumerator();
enumerator.MoveNext();
var _grad = enumerator.Current;
//enumerator.Reset(); // baca grešku!!

// projekcija rezultata

var artikli = new List<Artikl>()
{
    new() { Sifra = 100, Naziv = "Kruh", Barkod = 2323123213, StanjeNaSkladistu = 0, Vrsta = 1 },
    new Artikl() { Sifra = 240, Naziv = "Pivo", Barkod = 213213213, StanjeNaSkladistu = 2, Vrsta = 1 },
    new Artikl() { Sifra = 550, Naziv = "Deodorans", Barkod = 343243242, StanjeNaSkladistu = 45, Vrsta = 2 },
    new Artikl() { Sifra = 330, Naziv = "Mlijeko", Barkod = 43243243, StanjeNaSkladistu = 0, Vrsta = 1 }, 
    new Artikl() { Sifra = 440, Naziv = "Sapun", Barkod = 5454545, StanjeNaSkladistu = 4, Vrsta = 2 },
    new Artikl() { Sifra = 556, Naziv = "Šampon", Barkod = 4334343, StanjeNaSkladistu = 10, Vrsta = 2 },
    new Artikl() { Sifra = 444, Naziv = "Hladnjak", Barkod = 54545, StanjeNaSkladistu = 1, Vrsta = 4 }
};

artikli.ForEach(x => Console.WriteLine(x));

// SQL/Query sintaksa

var upit = (from artikl in artikli
            where artikl.StanjeNaSkladistu > 0
            select new { artikl.Sifra, artikl.Naziv }).ToList(); // ToArray();

// selector/method sintaksa

var upit2 = artikli // List<Artikl>
    .Where(artikl => artikl.StanjeNaSkladistu > 0) // IEnumerable<Artikl>
    .Select(artikl => new
    {
        artikl.Sifra,
        artikl.Naziv
    }) // IEnumerable<?>
    .ToList(); // List<?>

//var rezultat = upit.ToList();

var sortirano = from artikl in artikli
                orderby artikl.Naziv, artikl.Barkod descending
                select artikl;

//var rezultat = sortirano.ToList();

var sortirano2 = artikli
    .OrderBy(x => x.Naziv)
    .ThenByDescending(x => x.Barkod);

// OfType<T>

var mjesovito = new ArrayList();
mjesovito.Add(0);
mjesovito.Add("Jedan");
mjesovito.Add("Dva");
mjesovito.Add(3);
mjesovito.Add(new Artikl() { Sifra = 122, Naziv = "Pivo" });

var rezultat1 = from s in mjesovito.OfType<string>()
               select s;

var rezultat2 = from s in mjesovito.OfType<Artikl>()
                select s;

//var rezultat3 = from s in mjesovito.ToArray()
//                where s is Artikl
//                select s;

var osnovniUpit = from artikl in artikli
                  where artikl.StanjeNaSkladistu > 0 && artikl.StanjeNaSkladistu <= int.MaxValue
                  select artikl;

var rezultirajuciUpit = osnovniUpit
    .OrderBy(x => x.Naziv)
    .Take(5);
// .Skip(5)

foreach (var stavka in rezultirajuciUpit)
    Console.WriteLine(stavka);

// pozicijski operatori

var ima = osnovniUpit.ElementAt(0);
var nema = osnovniUpit.ElementAtOrDefault(0);
var prvi = osnovniUpit.First();
var zadnji = osnovniUpit.Last();

var provjera = rezultirajuciUpit.SequenceEqual(osnovniUpit);

// kvantifikatorski operatori

if (artikli.Any(_ => _.Naziv == "Vino"))
{
    Console.WriteLine("Zabava može početi!");
}
    
if (osnovniUpit.All(_ => _.StanjeNaSkladistu > 0))
{
    Console.WriteLine("Inventura može početi!");
}

//if (rezultirajuciUpit.Contains(new Artikl() { Sifra = 330, Naziv = "Mlijeko", Barkod = 43243243, StanjeNaSkladistu = 0 }))
if (!rezultirajuciUpit.Contains(artikli.ElementAt(3)))
{
    Console.WriteLine("Naručiti mlijeko!");
}

// filtriranje i projekcija:

var filtrirano = from artikl in artikli
                 where artikl.StanjeNaSkladistu > 0
                 select new { artikl.Barkod, artikl.Naziv };

filtrirano = artikli
    .Where(artikl => artikl.StanjeNaSkladistu > 0)
    .Select(x => new { x.Barkod, x.Naziv });

// sortiranje:

var abecedno = from a in artikli
               orderby a.Naziv
               select a;

abecedno = artikli.OrderBy(_ => _.Naziv);

var abecednoSilazno = from a in artikli
                      orderby a.Naziv descending
                      select a;

abecednoSilazno = artikli.OrderByDescending(_ => _.Naziv);

abecedno = from a in artikli
           orderby a.StanjeNaSkladistu, a.Naziv
           select a;

abecedno = artikli.OrderBy(a => a.StanjeNaSkladistu).ThenBy(a => a.Naziv);

abecedno = from a in artikli
           orderby a.StanjeNaSkladistu, a.Naziv descending
           select a;

abecedno = artikli.OrderBy(a => a.StanjeNaSkladistu).ThenByDescending(a => a.Naziv);

string recenica = "Što je danas lijepi sunčan dan!";
string[] rijeci = recenica.Split(' ');
var rez1 = rijeci.Count(_ => _.Contains("je"));

// grupiranje

var grupirano = from artikl in artikli
                group artikl by artikl.Vrsta;

grupirano = artikli.GroupBy(artikl => artikl.Vrsta);

foreach (var grupa in grupirano)
{
    Console.WriteLine("Vrsta artikla: " + grupa.Key);

    foreach (var clan in grupa)
    {
        Console.WriteLine($" - Šifra: {clan.Sifra}, Naziv: {clan.Naziv}");
    }
}

//var gr1 = (from artikl in artikli
//          group artikl by artikl.Vrsta).ToList();

grupirano = artikli.ToLookup(artikl => artikl.Vrsta);

// delegat:

Func<Artikl, bool> hranaNaZalihi = delegate (Artikl artikl)
{
    return artikl.StanjeNaSkladistu > 0 && artikl.Vrsta == 1;
};

var delUpit = from artikl in artikli
              //where artikl.StanjeNaSkladistu > 0
              //where artikl.Vrsta == 1
              where hranaNaZalihi(artikl)
              select artikl;

// spajanje

var voce1 = new List<string>()
{
    "Jabuka",
    "Banana",
    "Kruška",
    "Šljiva"
};

var voce2 = new List<string>()
{
    "Naranča",
    "Limun",
    "Banana",
    "Jabuka",
    "Grejp"
};

var z = voce1.SequenceEqual(voce2);

var podudarnosti = from niz1 in voce1
                   join niz2 in voce2  // inner join
                   on niz1 equals niz2
                   select niz1;

podudarnosti = voce1
    .Join(voce2, niz1 => niz1, niz2 => niz2, (niz1, niz2) => niz1);

foreach (var n in podudarnosti)
    Console.WriteLine(n);

var proizvodi1 = new List<Artikl>()
{ 
    new() { Sifra = 100, Naziv = "Kruh", Barkod = 2323123213, StanjeNaSkladistu = 0, Vrsta = 1 },
    new Artikl() { Sifra = 240, Naziv = "Pivo", Barkod = 213213213, StanjeNaSkladistu = 2, Vrsta = 1 },
    new Artikl() { Sifra = 440, Naziv = "Sapun", Barkod = 5454545, StanjeNaSkladistu = 4, Vrsta = 2 },
    new Artikl() { Sifra = 556, Naziv = "Šampon", Barkod = 4334343, StanjeNaSkladistu = 10, Vrsta = 2 }
};

var proizvodi2 = new List<Artikl>()
{
    new() { Sifra = 100, Naziv = "Kruh", Barkod = 2323123213, StanjeNaSkladistu = 0, Vrsta = 1 },
    new Artikl() { Sifra = 550, Naziv = "Deodorans", Barkod = 343243242, StanjeNaSkladistu = 45, Vrsta = 2 },
    new Artikl() { Sifra = 330, Naziv = "Mlijeko", Barkod = 43243243, StanjeNaSkladistu = 0, Vrsta = 1 },
    new Artikl() { Sifra = 440, Naziv = "Sapun", Barkod = 5454545, StanjeNaSkladistu = 4, Vrsta = 2 },
};

var match = from p1 in proizvodi1
            join p2 in proizvodi2
            on p1.Sifra equals p2.Sifra
            select p1;

match = proizvodi1.Join(proizvodi2, p1 => p1.Sifra, p2 => p2.Sifra, (p1, p2) => p1);

var vrsteArtikala = new List<VrstaArtikla>()
{
    new VrstaArtikla() { Sifra = 1, Naziv = "Hrana" },
    new VrstaArtikla() { Sifra = 2, Naziv = "Kozmetika" },
    new VrstaArtikla() { Sifra = 3, Naziv = "Alat" },
};

var spoj = artikli.Join(
    vrsteArtikala,
    proizvod => proizvod.Vrsta,
    vrsta => vrsta.Sifra,
    (proizvod, vrsta) => new
    {
        proizvod.Sifra,
        proizvod.Naziv,
        Vrsta = vrsta.Naziv,
        proizvod.Barkod,
        proizvod.StanjeNaSkladistu
    });

foreach (var item in spoj)
    Console.WriteLine(item);

// SELECT *
// FROM Artikl a
// LEFT OUTER JOIN VrstaArtikla v
//  ON a.Vrsta = v.Sifra

Console.WriteLine();
Console.WriteLine("LEFT OUTER JOIN");

var leftOuterJoin = artikli.GroupJoin(
    vrsteArtikala,
    proizvod => proizvod.Vrsta,
    vrsta => vrsta.Sifra,
    (proizvod, vrste) => new
    {
        proizvod,
        vrste
    });

// flattening, spljoštiti

var spljosteno = leftOuterJoin.SelectMany(
    x => x.vrste.DefaultIfEmpty(),
    (x, vrsta) => new
    {
        x.proizvod.Sifra,
        x.proizvod.Naziv,
        Vrsta = vrsta?.Naziv ?? "(nema podataka)",
        x.proizvod.Barkod,
        x.proizvod.StanjeNaSkladistu
    });

spljosteno =
    from proizvod in artikli
    join vrsta in vrsteArtikala
    on proizvod.Vrsta equals vrsta.Sifra
    into grupa
    from x in grupa.DefaultIfEmpty()
    select new
    {
        proizvod.Sifra,
        proizvod.Naziv,
        Vrsta = x?.Naziv ?? "(nema podataka)",
        proizvod.Barkod,
        proizvod.StanjeNaSkladistu
    };

foreach (var item in spljosteno)
    Console.WriteLine(item);

// agregatni operatori

var pobrojavanje = artikli.Count();
var zbroj = artikli.Sum(x => x.StanjeNaSkladistu);
var prosjek = artikli.Average(x => x.StanjeNaSkladistu);
var maksimum = artikli.Max(x => x.StanjeNaSkladistu);
var minimum = artikli.Min(x => x.StanjeNaSkladistu);

var agregacija = artikli.Aggregate<Artikl, string>(
    "Nazivi artikala: ", // početna vrijednost
    (trenutni, slijedeci) => trenutni += slijedeci + ", "); // funkcija agregacije
Console.WriteLine(agregacija);

Console.ReadLine();
