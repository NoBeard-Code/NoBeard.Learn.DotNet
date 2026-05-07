namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class ObradaPodataka
{
    public delegate void ProcesZavrsenDelegate(bool rezultat);

    public event EventHandler<FazaEventArgs> FazaZavrsena;
    public event ProcesZavrsenDelegate ProcesZavrsen;

    public bool PokreniProces()
    {
        for (byte i = 1;  i <= 10; i++)
        {
            //Console.WriteLine("Proces u tijeku, faza: {0}", i);

            var faza = new FazaEventArgs(i);

            faza.VrijemePocetka = DateTime.UtcNow;
            
            // ...
            Thread.Sleep(1000);

            faza.VrijemeZavrsetka = DateTime.UtcNow;

            FazaZavrsena?.Invoke(this, faza);
        }

        var rezultat = true;
        ProcesZavrsen?.Invoke(rezultat);
        return rezultat;    
    }

    public void PokreniFazu(byte i)
    {
        Thread.Sleep(1000);
    }
}
