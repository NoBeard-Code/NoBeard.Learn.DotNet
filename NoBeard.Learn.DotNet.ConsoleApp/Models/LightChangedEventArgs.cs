namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class LightChangedEventArgs : EventArgs
{
    public LightColor Color { get; }

    public LightChangedEventArgs(LightColor color)
    {
        Color = color;
    }
}
