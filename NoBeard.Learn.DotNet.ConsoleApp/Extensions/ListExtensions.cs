namespace NoBeard.Learn.DotNet.ConsoleApp.Extensions;

internal static class ListExtensions
{
    public static int Randomize(this List<int> list)
    {
        Random rnd = new Random();
        return rnd.Next(list.Count);
    }

    public static int RandomizeIndex<T>(this List<T> list)
    {
        Random rnd = new Random();
        return rnd.Next(list.Count);
    }
}
