namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal interface INotification
{
    string Message { get; set; }

    void Send();
}

internal class Notification : INotification
{
    public string Message { get; set; }

    public virtual void Send()
    {
        Console.WriteLine("Sending notification ...");
    }
}
