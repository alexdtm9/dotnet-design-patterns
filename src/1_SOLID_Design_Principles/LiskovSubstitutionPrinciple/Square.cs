namespace LiskovSubstitutionPrinciple;

public class Square : Rectangle
{
    public override int Width
    {
        set => base.Width = base.Height = value;
    }
    // public new int Width 
    // {
    //     set => base.Width = base.Height = value; This will break the Liskov Substitution Principle
    // }

    public override int Height
    {
        set => base.Width = base.Height = value;
    }
    // public new int Height
    // {
    //     set => base.Width = base.Height = value; This will break the Liskov Substitution Principle
    // }
}