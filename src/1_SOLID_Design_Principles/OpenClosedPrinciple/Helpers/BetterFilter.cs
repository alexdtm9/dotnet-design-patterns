using OpenClosedPrinciple.Abstractions;

namespace OpenClosedPrinciple.Helpers;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecifications<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
            {
                yield return item;
            }
        }
    }
}