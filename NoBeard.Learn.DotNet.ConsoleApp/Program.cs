using NoBeard.Learn.DotNet.ConsoleApp.Models;

var polaznik1 = new Polaznik { Sifra = 100, Ime = "Pero" };
Console.WriteLine(polaznik1);

var tip = polaznik1.GetType();
var kod1 = polaznik1.GetHashCode();

var polaznik2 = new Polaznik { Sifra = 100, Ime = "Pero" };

var x = (polaznik1 == polaznik2);
var y = (polaznik1.Equals(polaznik2));

var kod2 = polaznik2.GetHashCode();
var z = (kod1 == kod2);

Console.ReadLine();
