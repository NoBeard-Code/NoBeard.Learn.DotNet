using NoBeard.Learn.DotNet.ConsoleApp.Models;
using System.Text.Json;
using System.Xml.Serialization;

// JSON serijalizacija

/*
var racun = new Racun();
racun.Sifra = 1000;
racun.Naziv = "Tekući";

//var json = racun.Serialize();
//racun.Export("racun.json");
racun.Export();

SerijalizirajRacun(racun);

var rn1 = DeserijalizirajRacun();
Console.WriteLine(rn1?.Sifra);

*/

// XML serijalizacija

var polaznik = new Polaznik { Sifra = 100, Ime = "Pero" };

var serializer = new XmlSerializer(typeof(Polaznik));

//using var writer = new StringWriter();
var writer = new StringWriter();
serializer.Serialize(writer, polaznik);
string xml = writer.ToString();
writer.Close();

File.WriteAllText("polaznik.xml", xml);

xml = File.ReadAllText("polaznik.xml");

using var reader = new StringReader(xml);
Polaznik polaznik2 = (Polaznik)serializer.Deserialize(reader)!;
//Polaznik polaznik2 = serializer.Deserialize(reader) as Polaznik;

Console.ReadLine();

static void SerijalizirajRacun(Racun racun)
{
    var options = new JsonSerializerOptions()
    {
        WriteIndented = true,
    };

    try
    {
        var json = JsonSerializer.Serialize(racun, options);
        File.WriteAllText("racun.json", json);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static Racun? DeserijalizirajRacun()
{
    string? json = null;

    try
    {
        json = File.ReadAllText("racun.json");
        return JsonSerializer.Deserialize<Racun>(json);
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Datoteka nije nađena!");
        return null;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return null;
    }
}
