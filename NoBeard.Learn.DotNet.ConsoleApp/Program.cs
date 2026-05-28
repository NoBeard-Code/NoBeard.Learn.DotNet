using NoBeard.Learn.DotNet.ConsoleApp.Models;
using System.Collections;

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
    new() { Sifra = 100, Naziv = "Kruh", Barkod = 2323123213, StanjeNaSkladistu = 0 },
    new Artikl() { Sifra = 240, Naziv = "Pivo", Barkod = 213213213, StanjeNaSkladistu = 2 },
    new Artikl() { Sifra = 550, Naziv = "Deodorans", Barkod = 343243242, StanjeNaSkladistu = 45 },
    new Artikl() { Sifra = 330, Naziv = "Mlijeko", Barkod = 43243243, StanjeNaSkladistu = 0 }, 
    new Artikl() { Sifra = 440, Naziv = "Sapun", Barkod = 5454545, StanjeNaSkladistu = 4 },
    new Artikl() { Sifra = 556, Naziv = "Šampon", Barkod = 4334343, StanjeNaSkladistu = 10 }
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

Console.ReadLine();
