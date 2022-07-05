//string writing syntaxes
//CONCATENATION
string name = "Aaron";
string greeting = "Yo!";
Console.WriteLine(greeting + " My name is " + name);

//INTERPOLATION
Console.WriteLine($"{greeting} My name is {name}");

//COMPOSITE FORMATTING
Console.WriteLine("{0} My name is {1}", greeting, name);


//Casing Conventions
// camelCasing - Variables
int num = 9;
string thisIsALongVariableName = "yep";

//PascalCasing - Classes, Methods
// ThisIsPascalCasing
// Pascal

//snake_case
//this_is_snake_casing

//kebab-casing
//this-is-also-kebab-casing