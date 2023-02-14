using SingleResponsibilityPrinciple;

// Single Responsibility Principle =>  A class should have one and only one reason to change,
// meaning that a class should have only one job.

var j = new Journal();
j.AddEntry("I cried today.");
j.AddEntry("I ate a bug.");
Console.WriteLine(j);

var p = new Persistence();
var filename = @"c:\temp\journal.txt";
p.SaveToFile(j, filename, true);
// Process.Start(filename);