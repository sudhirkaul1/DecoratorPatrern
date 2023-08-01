using DecoratorPatternApp.CakeExample;

namespace DecoratorPatternApp.CakeDecorator;

public class CakeDecorator : ICakeDecorator
{
    private readonly ICake _cake;
    public CakeDecorator(ICake cake)
    {
        _cake = cake;
    }
    public void AddLayers(string layer)
    {
        _cake.AddLayers(layer);
    }

    public string AddMessage(string message)
    {
        return message;
    }
}