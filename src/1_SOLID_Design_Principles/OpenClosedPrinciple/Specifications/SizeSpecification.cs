using OpenClosedPrinciple.Abstractions;

namespace OpenClosedPrinciple.Specifications;

public class SizeSpecification : ISpecifications<T>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }

    public bool IsSatisfied(T item)
    {
        return item.Size == _size;
    }
}