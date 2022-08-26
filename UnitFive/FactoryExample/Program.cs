using FactoryExample;

var rectangleOne = ShapeFactory.CreateShape("RECTANGLE");
rectangleOne.Draw();
var rectangleTwo = ShapeFactory.CreateShape("RECTANGLE");
var circleOne = ShapeFactory.CreateShape("circle");

Console.WriteLine(circleOne.CalculateArea());