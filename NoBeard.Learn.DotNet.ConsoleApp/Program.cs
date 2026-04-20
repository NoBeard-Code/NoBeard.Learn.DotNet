using NoBeard.Learn.DotNet.ConsoleApp.Interfaces;
using NoBeard.Learn.DotNet.ConsoleApp.Models;
using System.Collections;

namespace NoBeard.Learn.DotNet.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        var tekuci = new TekuciRacun(1000, 100.00);
        var ziro = new ZiroRacun(2000, -50.00);

        var racuni = new ArrayList();
        racuni.Add(tekuci);
        racuni.Add(ziro);

        var kartica = new KreditnaKartica("1111 2222 3333 4444 5555", 150.00);

        var mBankarstvo = new List<IBezgotovinskoPlacanje>() { tekuci, ziro, kartica };
        foreach (var mRacun in mBankarstvo)
        {
            mRacun.Print();
        }

        var dzep = new Novcanik();
        dzep.Uplati(50.00);

        var kucneFinancije = new List<ISredstvoPlacanja>() { dzep, tekuci, ziro, kartica };
        foreach (var stavke in kucneFinancije)
        {
            stavke.Print();
        }

        WorkWithNotifications();
    }

    private static void WorkWithNotifications()
    {
        var notifications = new List<INotification>
            {
                new EmailNotification
                {
                    Message = "Your order has shipped!",
                    EmailAddress ="pero.peric@algebra.hr"
                },
                new SmsNotification
                {
                    Message = "Your code is 123456",
                    PhoneNumber = "+385 99 123456"
                }
            };

        foreach (var notification in notifications)
        {
            notification.Send();
        }
    }
}
