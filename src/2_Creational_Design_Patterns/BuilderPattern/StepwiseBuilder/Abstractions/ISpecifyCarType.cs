namespace BuilderPattern.StepwiseBuilder.Abstractions;

public interface ISpecifyCarType
{
    public ISpecifyWheelSize WithCarType(CarType carType);
}

public interface ISpecifyWheelSize
{
    public IBuildCar WithWheelSize(int wheelSize);
}

public interface IBuildCar
{
    public Car Build();
}