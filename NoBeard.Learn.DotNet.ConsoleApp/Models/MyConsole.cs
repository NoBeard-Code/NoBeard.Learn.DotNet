namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal static class MyConsole
{
    public static void WriteLine(string tekst)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(tekst);
        Console.ResetColor();
    }
}
