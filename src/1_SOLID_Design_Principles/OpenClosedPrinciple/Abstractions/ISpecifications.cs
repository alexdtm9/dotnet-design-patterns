namespace OpenClosedPrinciple.Abstractions;

public interface ISpecifications<T>
{
    bool IsSatisfied(T item);
}