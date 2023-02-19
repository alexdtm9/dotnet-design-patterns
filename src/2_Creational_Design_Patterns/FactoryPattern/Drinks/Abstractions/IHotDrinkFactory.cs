namespace FactoryPattern.Drinks.Abstractions;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}