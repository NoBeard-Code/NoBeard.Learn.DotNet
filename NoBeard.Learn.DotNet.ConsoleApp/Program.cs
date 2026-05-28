using NoBeard.Learn.DotNet.ConsoleApp.Models;
using System.Collections;

string[] gradovi = { "Varaždin", "Zagreb", "Osijek", "Vinkovci", "Slavonski Brod", "Split", "Sisak" };

// Query/SQL sintaksa upita

var query = from grad in gradovi
            where grad.StartsWith("S")
            select grad;

// Selector/metodna sintaksa upita

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

foreach (var grad in query)
{
    Console.WriteLine(grad);
}

var enumerator = query.GetEnumerator();
enumerator.MoveNext();
var _grad = enumerator.Current;
//enumerator.Reset();

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
           select new { artikl.Sifra, artikl.Naziv }).ToList();

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


Console.ReadLine();
