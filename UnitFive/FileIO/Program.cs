using FileIO;

string filePath = @"C:\Code\GrandCircus\CSharpBootcamp_June2022_AH\UnitFive\FileIO\TextFile.txt"; //absolute path
string relPath = @"..\..\..\..\TextFile.txt"; //relative path
List<Person> people = new List<Person>
{
    new Person("Bob", 33),
    new Person("Sally", 99)
};

StreamWriter writer = new StreamWriter(filePath); //overwrites the file everytime
//StreamWriter writer = new StreamWriter(filePath, true); //appends new text to the existing text

writer.WriteLine("some message");
writer.WriteLine("another message");

foreach (Person person in people)
{
    writer.WriteLine($"{person.Name},{person.Age}");
}

writer.Close();


StreamReader reader = new StreamReader(filePath);
//var firstLine = reader.ReadLine();
//Console.WriteLine(firstLine);

string line;
while((line = reader.ReadLine()) != null)
{
    Console.WriteLine(line);
}

reader.Close();



//checkout File class for similar functionality
//File.WriteAllLines(filePath, new string[] { "Bob", "Sally" });

//List<string> lines = File.ReadAllLines(filePath).ToList();

//foreach (string line in lines) Console.WriteLine(line);

//lines.Add("yet another line");

//File.WriteAllLines(filePath, lines);

//Console.WriteLine(File.ReadAllText(filePath));