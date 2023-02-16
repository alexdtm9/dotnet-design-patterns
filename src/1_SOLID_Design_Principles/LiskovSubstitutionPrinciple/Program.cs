using LiskovSubstitutionPrinciple;

// Liskov Substitution Principle => Objects in a program should be replaceable with instances of their subtypes
// without altering the correctness of that program.

static int Area(Rectangle r) => r.Width * r.Height;

var rectangle = new Rectangle(2, 3);
Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

var square = new Square();
square.Width = 4;
Console.WriteLine($"{square} has area {Area(square)}");

Rectangle rectangle2 = new Square();
rectangle2.Width = 4;
Console.WriteLine($"{rectangle2} has area {Area(rectangle2)}");