namespace DependencyInversionPrinciple.Abstractions;

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}