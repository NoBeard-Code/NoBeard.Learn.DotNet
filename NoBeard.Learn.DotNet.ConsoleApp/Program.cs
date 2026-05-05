namespace NoBeard.Learn.DotNet.ConsoleApp;

internal class Program
{
    public delegate void TestDelegate(string tekst);

    public delegate void TitleDelegate(string ime, string prezime);

    public delegate Weather WeatherForecastDelegate(string latitude, string longitude);

    internal enum Weather
    {
        Sunny,
        Rain,
        Snow
    }

    static void Main(string[] args)
    {
        TestDelegate del1 = new TestDelegate(MetodaA);

        del1.Invoke("pozivaj prvi puta");

        del1 = MetodaB; // new TestDelegate(MetodaB); 

        del1.Invoke("pozivaj drugi puta");

        del1("pozivaj treći puta");

        TestDelegate del2 = MetodaA;

        TestDelegate del3 = del1 + del2;
        del3.Invoke("rezultat");

        del3 -= del1;
        del3.Invoke("rez");

        del3 += del2;
        del3.Invoke("rezzz");

        TitleDelegate ispisSvjedodzbe = IspisiSvjedodzbu;
        TitleDelegate ispisPotvrde = IspisiPotvrdu;

        ispisSvjedodzbe("Pero", "Perić");
        ispisPotvrde("Maja", "Majić");


        //IspisiDokument("Pero", "Perić", "SVJEDODŽBA");

        IspisiDokument("Pero", "Perić", IspisiSvjedodzbu);
        IspisiDokument("Maja", "Majić", IspisiPotvrdu);

        WeatherForecastDelegate service = new WeatherForecastDelegate(CallWeatherService);
        ReportForecastForNearbyStation(service, "56.55", "34.232");
    }

    public static void MetodaA(string tekst)
    {
        Console.WriteLine($"Izvršavamo metodu A sa tekstom: {tekst}");
    }

    public static void MetodaB(string tekst)
    {
        Console.WriteLine($"Izvršavamo metodu B sa tekstom: {tekst}");
    }

    private static void IspisiSvjedodzbu(string ime, string prezime)
    {
        Console.WriteLine("SVJEDODŽBA:");
        Console.WriteLine($"Ime i prezime polaznika: {ime} {prezime}");
    }

    private static void IspisiPotvrdu(string ime, string prezime)
    {
        Console.WriteLine("POTVRDA:");
        Console.WriteLine($"Ime i prezime vozača: {ime} {prezime}");
    }

    private static void IspisiDokument(string ime, string prezime, string tipDokumenta)
    {
        Console.WriteLine("(slika grba)");
        Console.WriteLine($"Mjesto i datum izdavanja: {DateTime.Today}");

        if (tipDokumenta == "POTVRDA")
        {
            IspisiPotvrdu(ime, prezime);
        }
        else if (tipDokumenta == "SVJEDODŽBA")
        {
            IspisiSvjedodzbu(ime, prezime);
        }
    }

    private static void IspisiDokument(string ime, string prezime, TitleDelegate ispisDokumenta)
    {
        //ispisDokumenta.Invoke(ime, prezime);

        Console.WriteLine("(slika grba)");
        Console.WriteLine($"Mjesto i datum izdavanja: {DateTime.Today}");
        ispisDokumenta.Invoke(ime, prezime);
    }

    private static Weather CallWeatherService(string latitude, string longitude)
    {
        // TODO: implementiraj poziv na pravi servis!
        return Weather.Sunny;
    }

    private static void ReportForecastForNearbyStation(WeatherForecastDelegate service,  string latitude, string longitude)
    {
        var forecast = service.Invoke(latitude, longitude);

        Console.WriteLine($"Latitude: {latitude}");
        Console.WriteLine($"Longitude: {longitude}");
        Console.WriteLine($"Forecast for {DateTime.Now}: {forecast}");
    }

}