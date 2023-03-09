using StepwiseBuilder;

var car = CarBuilder
    .Create()
    .WithCarType(CarType.Crossover)
    .WithWheelSize(18)
    .Build();
    
Console.WriteLine(car);