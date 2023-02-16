namespace OpenClosedPrinciple;

public class ProductFilter
{
    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size) =>
        products.Where(product => product.Size == size);

    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color) =>
        products.Where(product => product.Color == color);

    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color) =>
        products.Where(product => product.Size == size && product.Color == color);
}