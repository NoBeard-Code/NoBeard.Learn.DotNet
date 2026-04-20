namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class EmailNotification : Notification
{
    public string EmailAddress { get; set; }

    public override void Send()
    {
        base.Send();
        Console.WriteLine($"Sending email to {EmailAddress}: {Message}");
    }
   
}
