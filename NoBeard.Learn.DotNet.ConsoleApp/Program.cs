using NoBeard.Learn.DotNet.ConsoleApp.Models;
using System.Text.Json;

// JSON serijalizacija

var racun = new Racun();
racun.Sifra = 1000;
racun.Naziv = "Tekući";

SerijalizirajRacun(racun);

var rn1 = DeserijalizirajRacun();
Console.WriteLine(rn1?.Sifra);

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
