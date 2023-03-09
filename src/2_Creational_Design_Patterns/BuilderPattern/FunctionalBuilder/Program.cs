// See https://aka.ms/new-console-template for more information

// With functional builder

using FunctionalBuilder;

var person = new PersonBuilder()
    .Called("Sarah")
    .WorksAsA("Engineer")
    .InDepartment("Engineering")
    .Build();

Console.WriteLine(person);