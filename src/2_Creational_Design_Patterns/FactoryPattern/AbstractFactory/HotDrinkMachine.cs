using AbstractFactory.Abstractions;

namespace AbstractFactory;

public class HotDrinkMachine
{
    // This commented implementation breaks the Open-Closed Principle !!!
    // public enum AvailableDrink
    // {
    //     Coffee,
    //     Tea
    // }
    //
    // private Dictionary<AvailableDrink, IHotDrinkFactory>
    //     _factories = new Dictionary<AvailableDrink, IHotDrinkFactory>();
    //
    // public HotDrinkMachine()
    // {
    //     foreach (var drink in Enum.GetValues(typeof(AvailableDrink)))
    //     {
    //         var factory = (IHotDrinkFactory)Activator.CreateInstance(
    //             Type.GetType("FactoryPattern.Drinks." +
    //                          Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
    //         _factories.Add((AvailableDrink)drink, factory);
    //     }
    // }
    //
    // public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    // {
    //     return _factories[drink].Prepare(amount);
    // }

    private List<Tuple<string, IHotDrinkFactory>> _factories =
        new List<Tuple<string, IHotDrinkFactory>>();

    public HotDrinkMachine()
    {
        foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                _factories.Add(Tuple.Create(
                    t.Name.Replace("Factory", string.Empty),
                    (IHotDrinkFactory)Activator.CreateInstance(t)));
            }
        }
    }

    public IHotDrink MakeDrink()
    {
        Console.WriteLine("Available drinks:");
        for (var index = 0; index < _factories.Count; index++)
        {
            var tuple = _factories[index];
            Console.WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            string s;
            int i;
            if ((s = Console.ReadLine()) != null &&
                int.TryParse(s, out i) &&
                i >= 0 &&
                i < _factories.Count)
            {
                Console.Write("Specify amount: ");
                s = Console.ReadLine();
                if (s != null &&
                    int.TryParse(s, out int amount) &&
                    amount > 0)
                {
                    return _factories[i].Item2.Prepare(amount);
                }
            }

            Console.WriteLine("Incorrect input, try again.");
        }
    }
}