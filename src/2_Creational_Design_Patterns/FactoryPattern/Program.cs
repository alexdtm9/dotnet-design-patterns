using FactoryPattern;

// Factory Pattern => a creational design pattern that provides an interface for creating objects in a superclass,
// but allows subclasses to alter the type of objects that will be created.

var point = Point.NewPolarPoint(1.0, Math.PI / 2);
Console.WriteLine(point.ToString());

var point2 = await Point.NewCartesianPointAsync(1.0, 1.0);
Console.WriteLine(point2.ToString());