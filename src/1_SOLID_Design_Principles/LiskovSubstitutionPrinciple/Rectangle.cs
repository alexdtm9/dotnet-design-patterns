namespace LiskovSubstitutionPrinciple;

public class Rectangle
{
    public virtual int Width { get; set; }
    // public int Width { get; set; } // This will break the Liskov Substitution Principle

    public virtual int Height { get; set; }
    // public int Height { get; set; } // This will break the Liskov Substitution Principle

    public Rectangle()
    {
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString() => $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
}