Console.WriteLine("Enter something: ");
string input = Console.ReadLine();
int num = -20;
bool isNum = int.TryParse(input, out num);
Console.WriteLine("isNum = " + isNum);
Console.WriteLine("num = " + num);

//Console.WriteLine("Do you like dogs? true/false");
//bool trueOrFalse = bool.Parse(Console.ReadLine());
//void PrintMessage (bool tOrF)
//{
//    Console.WriteLine($"Do you like dogs? {tOrF}");
//}
//PrintMessage(trueOrFalse);


//void PrintMessage(string input)
//{
//    Console.WriteLine(input);
//}
//PrintMessage("hello");


//Random random = new Random();
//Console.WriteLine(random.Next());
//Console.WriteLine(random.Next(10));
//Console.WriteLine(random.Next(-100, 100)); //low range is inclusive, hi range is exclusive


int numOne = 3;
int numTwo = 4;

static int AddTwoNumbersPlusOne(int a, out int b)
{
    b++;
    return a + b;
}

int sum = AddTwoNumbersPlusOne(numOne, out numTwo);
Console.WriteLine(sum);
Console.WriteLine("numTwo = " + numTwo);