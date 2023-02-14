using OpenClosedPrinciple.Abstractions;

namespace OpenClosedPrinciple.Specifications;

public class AndSpecification<T> : ISpecifications<T>
{
    private readonly ISpecifications<T> _first;
    private readonly ISpecifications<T> _second;

    public AndSpecification(ISpecifications<T> first, ISpecifications<T> second)
    {
        _first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        _second = second ?? throw new ArgumentNullException(paramName: nameof(second));
    }

    public bool IsSatisfied(T item)
    {
        return _first.IsSatisfied(item) && _second.IsSatisfied(item);
    }
}