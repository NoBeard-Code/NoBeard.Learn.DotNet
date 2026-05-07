namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class TrafficLight
{
    public string Name { get; }

    public LightColor Current { get; private set; }

    public event EventHandler<LightChangedEventArgs>? LightChanged;

    public TrafficLight(string name)
    {
        Name = name;
        Current = LightColor.Red;
    }

    public void SetLight(LightColor color)
    {
        Current = color;
        //Console.WriteLine($"{Name}: {color}");

        LightChanged?.Invoke(this, new LightChangedEventArgs(color));
    }
}
