namespace NoBeard.Learn.DotNet.ConsoleApp.Interfaces;

internal interface ITransportable
{
    string? Serialize();

    void Export(string filename);

    void Deserialize(string json);
}
