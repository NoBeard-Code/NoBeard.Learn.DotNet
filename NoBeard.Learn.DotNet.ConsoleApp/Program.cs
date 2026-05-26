using NoBeard.Learn.DotNet.ConsoleApp.Models;

/*
var polaznik1 = new Polaznik { Sifra = 100, Ime = "Pero" };
Console.WriteLine(polaznik1);

var tip = polaznik1.GetType();
var kod1 = polaznik1.GetHashCode();

var polaznik2 = new Polaznik { Sifra = 100, Ime = "Pero" };

var x = (polaznik1 == polaznik2);
var y = (polaznik1.Equals(polaznik2));

var kod2 = polaznik2.GetHashCode();
var z = (kod1 == kod2);

*/

var lista = new List<Polaznik>();
lista.Add(new Polaznik { Sifra = 100, Ime = "Maja" });
lista.Add(new Polaznik { Sifra = 101, Ime = "Pero" });
lista.Add(new Polaznik { Sifra = 102, Ime = "Andrea" });

lista.Remove(lista.Last());
lista.Remove(lista[lista.Count - 1]);
lista[0] = new Polaznik { Sifra = 103, Ime = "Tvrtko" };

var red = new Queue<string>(); // FIFO = first in, first out
red.Enqueue("Pero");
red.Enqueue("Maja");
red.Enqueue("Andrea");
var slijedeci = red.Dequeue();
slijedeci = red.Dequeue();

var stog = new Stack<string>(); // LIFO = last in, first out
stog.Push("Pero");
stog.Push("Maja");
stog.Push("Andrea");
var izlazi = stog.Pop();
izlazi = stog.Peek();
izlazi = stog.Pop();

var rijecnik = new Dictionary<int, Polaznik>();
rijecnik.Add(100, new Polaznik { Sifra = 100, Ime = "Maja" });
rijecnik.Add(101, new Polaznik { Sifra = 101, Ime = "Pero" });
rijecnik.Add(102, new Polaznik { Sifra = 102, Ime = "Andrea" });

rijecnik.TryGetValue(102, out var rezultat);
Polaznik? pretraga = rijecnik.GetValueOrDefault(103);
rijecnik.ContainsKey(105);
rijecnik.ContainsValue(lista.First());

Console.ReadLine();
