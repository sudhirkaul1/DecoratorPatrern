namespace DecoratorPatternApp.CakeExample;

public class ChocolateCake : ICake
{
    public void AddLayers(string layer)
    {
        Console.WriteLine($"Chocolate Layer Added as: {layer}");
    }
}