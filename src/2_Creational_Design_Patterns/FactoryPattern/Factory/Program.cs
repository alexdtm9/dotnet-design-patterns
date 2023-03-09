using Factory.Points;
using Factory.Themes;

// Factory Pattern => a creational design pattern that provides an interface for creating objects in a superclass,
// but allows subclasses to alter the type of objects that will be created.


// === Point Factory ===
var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
Console.WriteLine(point.ToString());
var point2 = await Point.Factory.NewCartesianPointAsync(1.0, 1.0);
Console.WriteLine(point2.ToString());

// === Theme Factory ===
var trackingThemeFactory = new TrackingThemeFactory();
var darkTheme = trackingThemeFactory.CreateTheme(true);
var lightTheme = trackingThemeFactory.CreateTheme(false);
Console.WriteLine(trackingThemeFactory.Info);
var darkTheme2 = trackingThemeFactory.CreateTheme(true);
Console.WriteLine(trackingThemeFactory.Info);

var replaceableThemeFactory = new ReplaceableThemeFactory();
var darkThemeRef = replaceableThemeFactory.CreateThemeRef(true);
var lightThemeRef = replaceableThemeFactory.CreateThemeRef(false);
Console.WriteLine(darkThemeRef.Value);
Console.WriteLine(lightThemeRef.Value);
replaceableThemeFactory.ReplaceThemeRef(true);
Console.WriteLine(darkThemeRef.Value.BackgroundColor);
Console.WriteLine(lightThemeRef.Value.BackgroundColor);
replaceableThemeFactory.ReplaceThemeRef(false);
Console.WriteLine(darkThemeRef.Value.BackgroundColor);
Console.WriteLine(lightThemeRef.Value.BackgroundColor);