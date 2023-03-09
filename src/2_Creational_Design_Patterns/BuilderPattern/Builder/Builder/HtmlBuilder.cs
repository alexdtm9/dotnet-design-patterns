namespace Builder.Builder;

public class HtmlBuilder
{
    private readonly string _rootName;
    private HtmlElement _root = new();

    public HtmlBuilder(string rootName)
    {
        this._rootName = rootName;
        _root.Name = rootName;
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);
        return this;
    }

    public override string ToString() => _root.ToString();

    public void Clear()
    {
        _root = new HtmlElement { Name = _rootName };
    }
}