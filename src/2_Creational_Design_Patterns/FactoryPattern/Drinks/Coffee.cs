using FactoryPattern.Drinks.Abstractions;

namespace FactoryPattern.Drinks;

internal class Coffee : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("This coffee is delicious!");
    }
}