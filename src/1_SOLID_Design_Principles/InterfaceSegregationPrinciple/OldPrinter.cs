using InterfaceSegregationPrinciple.Abstractions;

namespace InterfaceSegregationPrinciple;

// This printer can only print
public class OldPrinter : IMachine
{
    public void Print(Document d)
    {
        // ok
    }

    public void Fax(Document d)
    {
        throw new NotImplementedException();
    }

    public void Scan(Document d)
    {
        throw new NotImplementedException();
    }
}