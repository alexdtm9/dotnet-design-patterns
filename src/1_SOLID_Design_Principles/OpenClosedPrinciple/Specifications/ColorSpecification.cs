using OpenClosedPrinciple.Abstractions;

namespace OpenClosedPrinciple.Specifications;

public class ColorSpecification : ISpecifications<T>
{
    private readonly Color _color;
    
    public ColorSpecification(Color color)
    {
        _color = color;
    }
    
    public bool IsSatisfied(T item)
    {
        return item.Color == _color;
    }
}