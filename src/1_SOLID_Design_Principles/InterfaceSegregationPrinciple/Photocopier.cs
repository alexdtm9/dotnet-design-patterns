using InterfaceSegregationPrinciple.Abstractions;

namespace InterfaceSegregationPrinciple;

public class Photocopier : IPrinter, IScanner
{
    public void Print(Document d)
    {
        // ok
    }

    public void Scan(Document d)
    {
        // ok
    }
}