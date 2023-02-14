namespace OpenClosedPrinciple;

public class ProductFilter
{
    public IEnumerable<T> FilterBySize(IEnumerable<T> products, Size size) =>
        products.Where(product => product.Size == size);

    public IEnumerable<T> FilterByColor(IEnumerable<T> products, Color color) =>
        products.Where(product => product.Color == color);

    public IEnumerable<T> FilterBySizeAndColor(IEnumerable<T> products, Size size, Color color) =>
        products.Where(product => product.Size == size && product.Color == color);
}