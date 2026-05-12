using NoBeard.Learn.DotNet.ConsoleApp.Exceptions;
using NoBeard.Learn.DotNet.ConsoleApp.Models;

try
{
    int[] brojevi = { 1, 2, 3 };
    Console.WriteLine(brojevi[10]);
    Console.WriteLine("Uspješno!");
}
//catch // progutali exception!
catch (Exception ex)
{
    Console.WriteLine($"Dogodila se pogreška: {ex.Message}. Isprike!");
}
finally
{
    Console.WriteLine("Konačno kraj.");
}

static void Dijeljenje()
{
    var rez = Division(20, 0);

    Console.WriteLine(rez);

    static int Division(int a, int b)
    {
        int? result = null;

        try
        {
            result = a / b;
            return result.Value;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.ToString());
            result = -1;
        }

        return result.Value;
    }
}

static void Unos()
{
    while (true)
    {
        byte broj = 1;

        // int.TryParse - prevencija pretvorbe 
        try
        {
            Console.Write("Unesite broj: ");
            broj = byte.Parse(Console.ReadLine());

            if (broj == 0)
            {
                break;
            }

            Console.WriteLine($"Kvadrat broja {broj} je: {broj * broj}");
        }
        catch (OverflowException ofEx)
        {
            Console.WriteLine("Uneseni broj nije u dopuštenom opsegu!");
        }
        catch (FormatException fEx)
        {
            Console.WriteLine("Unos nije u vidu cijelog broja!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Nastupila je pogreška! " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Pokušajte unijeti slijedeći broj...");
        }
    }
}

static void VlastiteIznimke()
{

    var vozilo = new Vozilo("Fiat", "Doblo");
    vozilo.RegistrirajVozilo();

    var vozilo2 = new Vozilo("Renault", "Clio", true);

    try
    {
        //vozilo2.RegistrirajVozilo();
        //Console.WriteLine("Uspješno!");

        vozilo2.Popravi();
    }
    catch (VoziloException ex) when (ex.Vozilo != null && ex.Vozilo.Osteceno)
    {
        Console.WriteLine("Registracija nije moguća: {0}", ex.Message);
        if (ex.Vozilo != null)
        {
            Console.WriteLine("Vozilo marke {0}, modela {1}", ex.Vozilo.Marka, ex.Vozilo.Model);
        }
        if (ex.InnerException != null)
        {
            Console.WriteLine("Originalna greška je:" + ex.InnerException.Message);
        }
    }
    catch (VoziloException ex)
    {
        Console.WriteLine("Radnja nije moguća za vozilo marke {0}, modela {1}", ex.Vozilo!.Marka, ex.Vozilo!.Model);
        if (ex.InnerException != null)
        {
            Console.WriteLine("Originalna greška je:" + ex.InnerException.Message);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Dogodila se općenita greška: {0}", ex.Message);
    }
}