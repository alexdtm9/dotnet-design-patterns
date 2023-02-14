namespace SingleResponsibilityPrinciple;

public class Journal
{
    private readonly List<string> _entries = new();
    
    private static int _count = 0;
    
    public int AddEntry(string text)
    {
        _entries.Add($"{++_count}: {text}");
        return _count; // memento pattern
    }
    
    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }
    
    public override string ToString()
    {
        return string.Join(Environment.NewLine, _entries);
    }
    
    // here's the problem: these methods are not related to the journal
    // they are responsibility of a different class
    // public void Save(string filename)
    // {
    //     File.WriteAllText(filename, ToString());
    // }
    //
    // public static void Load(string filename)
    // {
    //     //
    // }
}