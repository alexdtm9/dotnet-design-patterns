using OpenClosedPrinciple.Abstractions;

namespace OpenClosedPrinciple.Specifications;

public class ColorSpecification : ISpecifications<Product>
{
    private readonly Color _color;
    
    public ColorSpecification(Color color)
    {
        _color = color;
    }
    
    public bool IsSatisfied(Product item)
    {
        return item.Color == _color;
    }
}