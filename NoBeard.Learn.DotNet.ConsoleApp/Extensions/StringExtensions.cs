namespace NoBeard.Learn.DotNet.ConsoleApp.Extensions;

internal static class StringExtensions
{
    public static void IspisiTekst(this string vrijednost)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(vrijednost);
        Console.ResetColor();
    }
}
