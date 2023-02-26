namespace BuilderPattern.BuilderInheritance;

public abstract class PersonBuilder
{
    protected Person person = new();
    
    public Person Build() => person;
}