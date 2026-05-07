using NoBeard.Learn.DotNet.ConsoleApp.Models;

namespace NoBeard.Learn.DotNet.ConsoleApp
{
    internal class Program : IDisposable
    {
        private static Racun racun = new Racun();

        static void Main(string[] args)
        {
            //var racun = new Racun();

            racun.StanjePromjenjeno += Racun_StanjePromjenjeno;
            //racun.StanjePromjenjeno += Racun_StanjePromjenjeno;

            racun.Uplati(50.00);
            //Console.WriteLine("Stanje je: " + racun.Stanje);

            racun.Uplati(120.00);
            //Console.WriteLine("Stanje je: " + racun.Stanje);

            racun.Isplati(20.00);
            //Console.WriteLine("Stanje je: " + racun.Stanje);

            racun.IsplatiSve();
            //Console.WriteLine("Stanje je: " + racun.Stanje);

            racun.StanjePromjenjeno -= Racun_StanjePromjenjeno;

            //racun = null;

            //racun.Uplati(500000.00);
        }

        private static void Racun_StanjePromjenjeno(object? sender, double e)
        {
            Console.WriteLine("Stanje je: " + e);
        }

        public void Dispose()
        {
            if (racun != null)
            {
                racun.StanjePromjenjeno -= Racun_StanjePromjenjeno;
            }
        }
    }
}