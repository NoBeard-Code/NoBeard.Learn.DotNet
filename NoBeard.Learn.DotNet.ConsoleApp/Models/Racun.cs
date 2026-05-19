using NoBeard.Learn.DotNet.ConsoleApp.Interfaces;
using System.Text.Json;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

[Serializable]
public class Racun : ITransportable
{
    private readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
    };

    public int Sifra { get; set; }

    public string Naziv { get; set; }

    public double Stanje { get; set; }

    public Racun()
    {
    }

    //public void Uplata(double iznos)
    //{
    //    if (iznos > 0)
    //    {
    //        Stanje += iznos;
    //    }
    //}

    //public void Isplata(double iznos)
    //{
    //    if (iznos > 0)
    //    {
    //        Stanje -= iznos;
    //    }
    //}

    public override string ToString()
    {
        return $"Racun, sifra: {Sifra}, naziv: {Naziv}";
    }

    public string? Serialize()
    {
        string? result = null;

        try
        {
            result = JsonSerializer.Serialize(this, _options);
        }
        catch (InvalidCastException icEx)
        {
            Console.WriteLine(icEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return result;
    }

    public void Deserialize(string json)
    {
        throw new NotImplementedException();
    }

    public void Export(string? filename = null)
    {
        filename ??= $"{nameof(Racun)}.json";

        try
        {
            var json = Serialize();
            if (json != null)
            {
                File.WriteAllText(filename, json);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
