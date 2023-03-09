namespace FunctionalBuilder;

public sealed class PersonBuilder
    :FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(p => p.Name = name);
    public PersonBuilder WorksAsA(string position) => Do(p => p.Position = position);
    public PersonBuilder InDepartment(string department) => Do(p => p.Department = department);
}