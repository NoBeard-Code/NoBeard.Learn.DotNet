using NoBeard.Learn.DotNet.ConsoleApp.Extensions;
using NoBeard.Learn.DotNet.ConsoleApp.Models;

namespace NoBeard.Learn.DotNet.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string tekst = "Pero Perić";

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"{tekst}");
            //Console.ResetColor();

            //IspisiTekst(tekst);

            tekst.IspisiTekst();

            Console.WriteLine("Pišem drugi tekst");

            var racun = new Racun();
            racun.Sifra = 1000;
            racun.Naziv = "Tekući";
            racun.Uplati(200.00);
            racun.Isplati(500.00);

            Console.WriteLine("Pišem drugi tekst");

            var datum = DateTime.Now;
            datum.AddDays(2);

            //if (datum.DayOfWeek == DayOfWeek.Sunday || datum.DayOfWeek == DayOfWeek.Saturday)
            //{

            //}

            var brojevi = new List<int>() { 1, 23, 55, 44, 32, 23, 8 };
            var slucajniBroj = brojevi.Randomize();

            var racuni = new List<Racun>() { racun };
            racuni.RandomizeIndex();


        }

        static void IspisiTekst(string tekst)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{tekst}");
            Console.ResetColor();
        }


    }

    internal static class Hacks
    {
        public static void Isplati(this Racun racun, double iznos)
        {
            racun.Stanje -= iznos;
        }
    }
}