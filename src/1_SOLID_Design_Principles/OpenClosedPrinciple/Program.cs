using OpenClosedPrinciple;
using OpenClosedPrinciple.Helpers;
using OpenClosedPrinciple.Specifications;

// Open Closed Principle =>  Classes should be open for extensions but they should be closed for modifications.

var products = new List<T>
{
    new T("Apple", Color.Green, Size.Small),
    new T("Tree", Color.Green, Size.Large),
    new T("House", Color.Blue, Size.Large)
};

var pf = new ProductFilter();
Console.WriteLine("Green products (old):");
foreach (var product in pf.FilterByColor(products, Color.Green))
{
    Console.WriteLine($" - {product.Name} is green");
}

var bf = new BetterFilter();
Console.WriteLine("Green products (new):");
foreach (var product in bf.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($" - {product.Name} is green");
}

Console.WriteLine("Large blue products:");
foreach (var product in bf.Filter(products,
             new AndSpecification<T>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
{
    Console.WriteLine($" - {product.Name} is large and blue");
}