using DependencyInversionPrinciple;

// Dependency Inversion Principle => High-level modules should not depend on low-level modules.
// Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions.

var parent = new Person {Name = "John"};
var child1 = new Person {Name = "Chris"};
var child2 = new Person {Name = "Matt"};

var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);

var research = new Research(relationships); // High-level: find all of john's children
