// See https://aka.ms/new-console-template for more information
using Lesson_2;

Console.WriteLine("Hello, World!");

Person person = new("Arxn", "3194");

Console.WriteLine(person.Name);

person.SetName("Nurbaht");

Console.WriteLine(person.Name);

Console.Clear();

/// <summary>
/// Interface
/// </summary>
/// <returns></returns>
/// 
IShape circle = new Circle(5);
IShape rectangle = new Rectangle(4, 6);

Console.WriteLine($"Circle Area: {circle.Area()}");
Console.WriteLine($"Circle Perimeter: {circle.Perimeter()}");

Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter()}");