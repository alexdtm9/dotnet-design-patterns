namespace InterfaceSegregationPrinciple.Abstractions;

public interface IMachine
{
    void Print(Document d);
    void Fax(Document d);
    void Scan(Document d);
}