namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public class Polaznik : IEquatable<Polaznik>
{
    public int Sifra { get; set; }

    public string Ime { get; set; } = string.Empty;

    public bool Equals(Polaznik? other)
    {
        if (other is null) 
            return false;

        return (this.Sifra == other.Sifra && this.Ime == other.Ime);
    }

    public override string ToString()
    {
        return $"Šifra: {Sifra}, Ime: {Ime}";
    }

    public override bool Equals(object? obj)
        => Equals(obj as Polaznik);

    public override int GetHashCode()
        => HashCode.Combine(Sifra, Ime);

    public static bool operator ==(Polaznik? polaznik1, Polaznik? polaznik2)
        => Equals(polaznik1, polaznik2);

    public static bool operator !=(Polaznik polaznik1, Polaznik polaznik2)
        => !Equals(polaznik1, polaznik2);
}
