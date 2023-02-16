using DependencyInversionPrinciple.Abstractions;

namespace DependencyInversionPrinciple;

public class Relationships : IRelationshipBrowser
{
    private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
        Relations.Add((parent, Relationship.Parent, child));
        Relations.Add((child, Relationship.Child, parent));
    }

    public List<(Person, Relationship, Person)> Relations
    {
        get => _relations;
        set => _relations = value;
    }
    
    public IEnumerable<Person> FindAllChildrenOf(string name) =>
        Relations
            .Where(x => x.Item1.Name == name
                        && x.Item2 == Relationship.Parent)
            .Select(r => r.Item3);
}