namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Connection
{
    private static Connection _instance;

    private Connection() { }

    public static Connection Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Connection();
            }

            return _instance;
        }
    }

    public void Open()
    {

    }
}
