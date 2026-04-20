using System.Collections;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public class ShuffledArrayList : ArrayList
{
    private Random _rnd = new Random();

    public void Shuffle()
    {
        for (int i = Count - 1; i > 0; i--)
        {
            int j = _rnd.Next(i + 1);

            object temp = this[i];
            this[i] = this[j];
            this[j] = temp;
        }
    }
}
