// See https://aka.ms/new-console-template for more information
using DecoratorPatternApp.CakeDecorator;
using DecoratorPatternApp.CakeExample;

Console.WriteLine("Hello, World!");

ICakeDecorator cake = new CakeDecorator(new ChocolateCake());
cake.AddLayers("Double Chocolate");
Console.WriteLine(cake.AddMessage("Happy Birthday!"));

cake = new CakeDecorator(new VanillaCake());
cake.AddLayers("Mint layer");
Console.WriteLine(cake.AddMessage("Happy Birthday!"));
