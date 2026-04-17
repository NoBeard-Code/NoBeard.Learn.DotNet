namespace NoBeard.Learn.DotNet.ConsoleApp.Models;

internal class Animal
{
    public string Name { get; set; }
   
    public virtual string Speak()
    {
        return "Animal sound";
    }
}
