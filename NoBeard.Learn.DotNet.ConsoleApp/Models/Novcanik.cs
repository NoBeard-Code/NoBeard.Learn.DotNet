using NoBeard.Learn.DotNet.ConsoleApp.Interfaces;

namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

public class Novcanik : ISredstvoPlacanja
{
    public double Stanje { get; set; }

    public void Isplati(double iznos)
    {
        if (Stanje - iznos < 0)
        {
            throw new Exception("Nije moguće ići u negativno stanje!");
        }
        else
        {
            Stanje -= iznos;
        }
    }

    public void Uplati(double iznos)
    {
        Stanje += iznos;
    }

    public void Print()
    {
        Console.WriteLine($"Moj novčanik:");

        if (Stanje > 50)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (Stanje == 0)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        Console.WriteLine("Stanje: {0:0.00} EUR", Stanje);

        Console.ResetColor();
    }
}
