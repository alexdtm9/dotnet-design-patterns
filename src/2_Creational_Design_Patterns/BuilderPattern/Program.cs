using System.Text;
using BuilderPattern;
using BuilderPattern.Builder;
using BuilderPattern.BuilderInheritance;
using BuilderPattern.StepwiseBuilder;

// Without builder
var hello = "Hello";
var sb = new StringBuilder();
sb.Append("<p>");
sb.Append(hello);
sb.Append("</p>");
Console.WriteLine(sb);

var words = new[] { "hello", "world" };
sb.Clear();
sb.Append("<ul>");
foreach (var word in words)
{
    sb.Append($"<li>{word}</li>");
}

sb.Append("</ul>");
Console.WriteLine(sb);

// With builder
var builder = new HtmlBuilder("ul");
builder
    .AddChild("li", "hello")
    .AddChild("li", "world"); // Fluent interface
Console.WriteLine(builder.ToString());

// With inheritance
var person = Person.New
    .Called("John")
    .WorksAsA("Engineer")
    .Build();
Console.WriteLine(person);

// With stepwise builder
var car = CarBuilder
    .Create()
    .WithCarType(CarType.Crossover)
    .WithWheelSize(18)
    .Build();
    
Console.WriteLine(car);