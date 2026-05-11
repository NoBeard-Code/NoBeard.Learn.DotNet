int broj = 10;

//Nullable<int> slobodni = null;
int? slobodni = null;

broj = slobodni.HasValue ? slobodni.Value : 0; // ternary conditional operator

broj = slobodni ?? 0; // null-coalescing operator

slobodni += 2;

broj = slobodni.GetValueOrDefault();

if (slobodni.HasValue)
{
    Console.Write(slobodni.Value);
}
else
{
    Console.Write("to je null");
}

Osoba? osoba = null; // = new Osoba();

if (osoba != null && osoba.Sifra > 10)
{

}

if (osoba?.Sifra > 10)
{

}

osoba = new Osoba();

if (osoba!.Sifra > 10)
{

}

Console.ReadLine();

public class Osoba
{
    public int? Sifra { get; set; }

    public string Naziv { get; set; }
}

