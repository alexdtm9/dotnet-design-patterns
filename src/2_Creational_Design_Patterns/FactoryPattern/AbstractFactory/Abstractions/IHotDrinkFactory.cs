namespace AbstractFactory.Abstractions;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}