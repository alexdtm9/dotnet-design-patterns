using OpenClosedPrinciple.Abstractions;

namespace OpenClosedPrinciple.Specifications;

public class SizeSpecification : ISpecifications<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }

    public bool IsSatisfied(Product item)
    {
        return item.Size == _size;
    }
}