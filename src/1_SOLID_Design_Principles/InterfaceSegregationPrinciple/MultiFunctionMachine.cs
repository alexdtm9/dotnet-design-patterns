using InterfaceSegregationPrinciple.Abstractions;

namespace InterfaceSegregationPrinciple;

public class MultiFunctionMachine : IMultiFunctionDevice
{
    private IPrinter printer;
    private IScanner scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
        this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
    }

    // Decorator pattern
    public void Print(Document d)
    {
        printer.Print(d);
    }

    // Decorator pattern
    public void Scan(Document d)
    {
        scanner.Scan(d);
    }
}