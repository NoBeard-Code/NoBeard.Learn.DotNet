namespace NoBeard.Learn.DotNet.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // value types:

            string ime = "Pero";

            Console.WriteLine("Pozdrav, " + ime + "!");
            Console.WriteLine($"Pozdrav, {ime}!");
            Console.WriteLine("Pozdrav, {0}!", ime);

            Console.Write("Pozdrav, ");
            Console.Write(ime);
            Console.WriteLine("!");

            Console.Write("Pozdrav, " + ime + "!\n");

            int godine = 25;

            Console.WriteLine(godine);

            Console.WriteLine("Pozdrav, {0} sa {1} godina", ime, godine);

            // conversions:

            var a = "100";
            var b = 200;
            var c = Int64.Parse(a) + b;
            var d = Convert.ToInt16(b);

            var e = Int64.TryParse("abc", out var f);

            var unos = Console.ReadLine();
            double rezultat = Convert.ToDouble(unos);

            var rezultat2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(rezultat2 * 1.25);

            // numeric & boolean:

            //byte ocjene = 5;
            //byte ocjena2 = -4;

            //short ocjene3 = -255;
            //ushort ocjene4 = -255;

            //int rgb = 0x343433;
            //byte rgb2 = 0b_0010_1111;

            bool programiranjeJeZabavno = true;
            bool vaniPadaKisa = false;

            Console.WriteLine(programiranjeJeZabavno && vaniPadaKisa);
            Console.WriteLine(programiranjeJeZabavno || vaniPadaKisa);
            Console.WriteLine(vaniPadaKisa);
            Console.WriteLine(!vaniPadaKisa);

            //int a = 10;
            //int b = 20;

            //Console.WriteLine(a < b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);

            //Console.WriteLine(a < b && b == 0);

            Console.WriteLine(ime == "Mato");
            Console.WriteLine(ime != "Ivica");

            string pwd = "";
            Console.WriteLine(ime == "pero@algebra.hr" && pwd == "pero123");

            Console.ReadKey();
        }
    }
}