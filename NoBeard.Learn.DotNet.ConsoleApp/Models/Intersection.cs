namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Intersection
{
    public TrafficLight North { get; }
    public TrafficLight South { get; }
    public TrafficLight East { get; }
    public TrafficLight West { get; }

    public Intersection()
    {
        North = new TrafficLight("North");
        South = new TrafficLight("South");
        East = new TrafficLight("East");
        West = new TrafficLight("West");

        // Subscribe to NS pair
        North.LightChanged += OnNorthSouthChanged;
        South.LightChanged += OnNorthSouthChanged;

        // Subscribe to EW pair
        East.LightChanged += OnEastWestChanged;
        West.LightChanged += OnEastWestChanged;

        North.LightChanged += OnLightChanged;
        South.LightChanged += OnLightChanged;
        East.LightChanged += OnLightChanged;
        West.LightChanged += OnLightChanged;
    }

    private void OnNorthSouthChanged(object? sender, LightChangedEventArgs e)
    {
        if (e.Color == LightColor.Green)
        {
            East.SetLight(LightColor.Red);
            West.SetLight(LightColor.Red);
        }
    }

    private void OnEastWestChanged(object? sender, LightChangedEventArgs e)
    {
        if (e.Color == LightColor.Green)
        {
            North.SetLight(LightColor.Red);
            South.SetLight(LightColor.Red);
        }
    }

    public void Run()
    {
        while (true)
        {
            // NS green
            North.SetLight(LightColor.Green);
            South.SetLight(LightColor.Green);
            Thread.Sleep(2000);

            North.SetLight(LightColor.Yellow);
            South.SetLight(LightColor.Yellow);
            Thread.Sleep(1000);

            North.SetLight(LightColor.Red);
            South.SetLight(LightColor.Red);
            Thread.Sleep(1000);

            // EW green
            East.SetLight(LightColor.Green);
            West.SetLight(LightColor.Green);
            Thread.Sleep(2000);

            East.SetLight(LightColor.Yellow);
            West.SetLight(LightColor.Yellow);
            Thread.Sleep(1000);

            East.SetLight(LightColor.Red);
            West.SetLight(LightColor.Red);
        }
    }

    private void OnLightChanged(object? sender, LightChangedEventArgs e)
    {
        Console.Clear();
        Console.WriteLine("   TRAFFIC INTERSECTION\n");

        DrawLight("North", North.Current);
        Console.WriteLine("        │");
        Console.WriteLine("        │");
        DrawLight("West", West.Current, inline: true);
        Console.Write(" ─────┼───── ");
        DrawLight("East", East.Current, inline: true);
        Console.WriteLine();
        Console.WriteLine("        │");
        Console.WriteLine("        │");
        DrawLight("South", South.Current);
    }

    private void DrawLight(string name, LightColor color, bool inline = false)
    {
        if (!inline)
            Console.Write($"{name,-6}: ");

        ConsoleColor c = color switch
        {
            LightColor.Red => ConsoleColor.Red,
            LightColor.Yellow => ConsoleColor.Yellow,
            LightColor.Green => ConsoleColor.Green,
            _ => ConsoleColor.White
        };

        WriteColor(color.ToString(), c);

        if (!inline)
            Console.WriteLine();
    }

    private static void WriteColor(string text, ConsoleColor color)
    {
        var old = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ForegroundColor = old;
    }
}
