using InterfaceSegregationPrinciple.Abstractions;

namespace InterfaceSegregationPrinciple;

public class MultiFunctionPrinter : IMachine
{
    public void Print(Document d)
    {
        // ok
    }

    public void Fax(Document d)
    {
        // ok
    }

    public void Scan(Document d)
    {
        // ok
    }
}