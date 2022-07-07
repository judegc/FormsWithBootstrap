using System.Text;

//Console.WriteLine("Enter something: ");
//string input = Console.ReadLine();
//int num = -20;
//bool isNum = int.TryParse(input, out num);
//Console.WriteLine("isNum = " + isNum);
//Console.WriteLine("num = " + num);

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


//int numOne = 3;
//int numTwo = 4;

//static int AddTwoNumbersPlusOne(int a, ref int b)
//{
//    b++;
//    return a + b;
//}

//int sum = AddTwoNumbersPlusOne(numOne, ref numTwo);
//Console.WriteLine(sum);
//Console.WriteLine("numTwo = " + numTwo);


//STRING METHODS
//string name = "bob";
//string combinedString = string.Concat("Hey", name);
//Console.WriteLine(combinedString);

//string name = "bob";
//Console.WriteLine("bob" == name);
//Console.WriteLine(name.Equals("bob"));
//Console.WriteLine(string.Compare(name, "bob"));
//Console.WriteLine(string.Compare(name, "BOB", true));
//Console.WriteLine(string.Equals(name, "BoB", StringComparison.OrdinalIgnoreCase));


string s = "abc abc abc";
//Console.WriteLine(s.IndexOf("bc"));
//Console.WriteLine(s.LastIndexOf("bc"));
//Console.WriteLine(s.EndsWith("?"));

//string newString = s.Replace("abc", "xyz");
//Console.WriteLine(newString);

//string[] stringArray = s.Split("b");
//foreach(string str in stringArray)
//{
//    Console.WriteLine(str);
//}

//string newString = s.Substring(3, 4);
//Console.WriteLine(newString);

//Console.WriteLine(s.ToUpper());

//string anotherString = "k lkjfd k";
//Console.WriteLine(anotherString.Trim());
//Console.WriteLine(anotherString.Trim('k'));

//Console.WriteLine(s.Contains('z'));


//Console.WriteLine(s);
//string string99 = s.Replace("abc", "xyz");
//Console.WriteLine(s);
//Console.WriteLine(string99);


//StringBuilder sb = new StringBuilder("bob");
//Console.WriteLine(sb);
//sb.Append("ABC");
//Console.WriteLine(sb);