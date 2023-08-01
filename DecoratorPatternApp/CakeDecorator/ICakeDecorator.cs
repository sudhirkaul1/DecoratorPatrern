using DecoratorPatternApp.CakeExample;

namespace DecoratorPatternApp.CakeDecorator;

public interface ICakeDecorator : ICake
{
    string AddMessage(string message);
}