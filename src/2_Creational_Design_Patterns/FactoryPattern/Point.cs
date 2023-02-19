namespace FactoryPattern;

public enum CoordinateSystem
{
    Cartesian,
    Polar
}

public class Point
{
    private double _x, _y;
    
    // As we can see, the constructor is not good enough to create a point
    // public Point(double x, double y, CoordinateSystem system = CoordinateSystem.Cartesian)
    // {
    //     switch (system)
    //     {
    //         case CoordinateSystem.Cartesian:
    //             this._x = x;
    //             this._y = y;
    //             break;
    //         case CoordinateSystem.Polar:
    //             this._x = x * Math.Cos(y);
    //             this._y = x * Math.Sin(y);
    //             break;
    //         default:
    //             throw new ArgumentOutOfRangeException(nameof(system), system, null);
    //     }
    // }

    private Point(double x, double y)
    {
        this._x = x;
        this._y = y;
    }

    // Factory method
    public static Point NewCartesianPoint(double x, double y)
    {
        return new Point(x, y);
    }
    
    // Factory method
    public static Point NewPolarPoint(double rho, double theta)
    {
        return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
    
    // Factory method with async => awaiting is not possible in a constructor => we need a factory method
    public static async Task<Point> NewCartesianPointAsync(double x, double y)
    {
        // await other async tasks
        // ...
        return await Task.Run(() => new Point(x, y));
    }
    
    public override string ToString()
    {
        return $"x: {_x}, y: {_y}";
    }
}