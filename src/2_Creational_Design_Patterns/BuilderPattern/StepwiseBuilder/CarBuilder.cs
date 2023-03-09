namespace StepwiseBuilder;

public class CarBuilder
{
    private class Implementation : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
    {
        private Car car = new();

        public ISpecifyWheelSize WithCarType(CarType carType)
        {
            car.Type = carType;
            return this;
        }

        public IBuildCar WithWheelSize(int wheelSize)
        {
            car.WheelSize = wheelSize;
            return this;
        }

        public Car Build() => car;
    }

    public static ISpecifyCarType Create()
    {
        return new Implementation();
    }
}