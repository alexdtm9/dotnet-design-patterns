using OpenClosedPrinciple.Abstractions;

namespace OpenClosedPrinciple.Helpers;

public class BetterFilter : IFilter<T>
{
    public IEnumerable<T> Filter(IEnumerable<T> items, ISpecifications<T> spec)
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