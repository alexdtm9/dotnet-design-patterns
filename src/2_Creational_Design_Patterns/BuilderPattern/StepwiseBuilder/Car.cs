namespace BuilderPattern.StepwiseBuilder;

public class Car
{
    public CarType Type { get; set; }
    public int WheelSize { get; set; }
    
    public override string ToString()
    {
        return $"Car type: {Type}, wheel size: {WheelSize}";
    }
}