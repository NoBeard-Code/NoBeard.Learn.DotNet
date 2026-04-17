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

            // TEXTUAL

            string rijec = " Algebra  ";

            Console.WriteLine(rijec);

            // operacije/metode nad varijablom:

            Console.WriteLine(rijec.ToLower());
            Console.WriteLine(rijec.ToUpper());
            Console.WriteLine(rijec.TrimStart(' '));
            Console.WriteLine(rijec.TrimEnd(' '));
            Console.WriteLine(rijec.Trim());

            // svojstva varijable:
            
            Console.WriteLine(rijec.Length);
            Console.WriteLine(rijec.TrimStart(' ').Length);
            Console.WriteLine(rijec.TrimEnd(' ').Length);
            Console.WriteLine(rijec.Trim().Length);

            //char a = 'a';
            //char l = 'l';
            //char g = 'g';
            //char e = 'e';
            //char b = 'b';
            //char r = 'r';

            //Console.WriteLine("" + a + l + g + e + b + r + a);
            //Console.WriteLine(string.Concat(a, l, g, e, b, r, a));

            //Console.WriteLine(a + l + g + e + b + r + a);
            //var kod = char.GetNumericValue(a);

            // escape characters: \n \\ \" \'
            Console.WriteLine("Ovo je neki,\n teks \\ t u \"navodnicima\" !?");

            int broj = 1024;
            Console.WriteLine(broj);
            Console.WriteLine(broj.ToString());

            Convert.ToString(broj);
            Int32.Parse(broj.ToString());

            // string je niz znakova:

            string jelo = "Lasagna";
            Console.WriteLine(jelo.First());
            Console.WriteLine(jelo.Last());
            Console.WriteLine(jelo.Substring(1));
            Console.WriteLine(jelo.Substring(2, 3));
            Console.WriteLine(jelo.IndexOf('n'));
            Console.WriteLine(jelo.IndexOf("gn"));
            Console.WriteLine(jelo.IndexOf('ž'));

            string recenica = "Jedna obična rečenica";
            string[] rijeci = recenica.Split(' ');

            string red = "1234;Pero;Perić;ulica;14"; // CSV

            Console.WriteLine(red.Replace("Pero", "Marko"));

            var polja = red.Split(';');
            Console.WriteLine(red.Split(';').Last());

            var x = Int32.Parse(red.Split(';').First()).ToString().Split().Length;
                          
            Console.ReadKey();
        }
    }
}