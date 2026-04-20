namespace NoBeard.Learn.DotNet.ClassLibrary.Structures;

public readonly struct Coordinates
{
    public double X { get; init; }

    public double Y { get; init; }

    public Coordinates(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
