namespace DecoratorPatternApp.CakeExample;

public class VanillaCake : ICake
{
    public void AddLayers(string layer)
    {
        Console.WriteLine($"Vanilla Layer Added as: {layer}");
    }
}