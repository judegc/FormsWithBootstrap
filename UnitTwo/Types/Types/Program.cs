//Examples of data types, reassigning values, parsing input from the user, and writing to the console window
//To run one example at a time, comment out all other examples

int numberOne; //declare
numberOne = 2; //intitialize
Console.WriteLine(numberOne);
numberOne = 1;
Console.WriteLine(numberOne);
numberOne = numberOne * 2;
Console.WriteLine(numberOne);


Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + ". It's nice to meet you!");

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
float x = float.Parse(input);
Console.WriteLine("Enter another number:");
float y = float.Parse(Console.ReadLine());
Console.WriteLine(x * y);

Console.WriteLine("Enter a number: ");
float number = float.Parse(Console.ReadLine());
Console.WriteLine(number + .5);