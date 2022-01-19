// See https://aka.ms/new-console-template for more information
using CarFunction;

Console.WriteLine("Hello, World!");

Car car1 = new Car();
Console.WriteLine(car1.Color);
car1.Color = "Red";
Console.WriteLine(car1.Color);
car1.Fuel = 10;
Console.WriteLine(car1.Fuel);
car1.Start();
car1.Start(100);