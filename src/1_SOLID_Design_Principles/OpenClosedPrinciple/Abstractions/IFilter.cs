namespace OpenClosedPrinciple.Abstractions;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecifications<T> spec);
}