namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class SmsNotification : Notification
{
    public string PhoneNumber { get; set; }

    public override void Send()
    {
        base.Send();
        Console.WriteLine($"Sending SMS to {PhoneNumber}: {Message}");
    }
}
