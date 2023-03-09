namespace FunctionalBuilder;

public class Person
{
    public string Name, Position, Department;
    
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}, {nameof(Department)}: {Department}";
    }
} 