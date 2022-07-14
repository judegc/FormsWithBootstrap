//Lists
List<int> nums = new List<int>();
nums.Add(9);
nums.Add(10);
//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("The first element of this list is: " + nums[0]);
//Console.WriteLine($"There are {nums.Count()} elements in this list");

nums.Insert(1, 123);
//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}

List<string> students = new List<string>() { "Michael", "Morgan", "Jacob", "Garret", "Brennan", "Jacob" };
//for loop with .Count()
for (int i = 0; i < students.Count(); i++)
{
    Console.WriteLine(students[i]);
}

//.IndexOf()
int index = students.IndexOf("Jacob");
Console.WriteLine(index);

//.LastIndexOf()
Console.WriteLine(students.LastIndexOf("Jacob"));

//.Sort()
students.Sort();
for (int i = 0; i < students.Count(); i++)
{
    Console.WriteLine(students[i]);
}

//.Reverse()
students.Reverse();
for (int i = 0; i < students.Count(); i++)
{
    Console.WriteLine(students[i]);
}

//.Clear()
students.Clear();
for (int i = 0; i < students.Count(); i++)
{
    Console.WriteLine(students[i]);
}






//Dictionaries
Dictionary<string, bool> tasty = new Dictionary<string, bool>();
tasty.Add("Chicken Curry", true);
tasty.Add("Steamed Broccoli", false);
//foreach (KeyValuePair<string, bool> kvp in tasty)
//{
//    if(kvp.Value)
//    {
//        Console.WriteLine(kvp.Key + " is delicious.");
//    }
//    else Console.WriteLine(kvp.Key + " is gross.");
//}

//Console.WriteLine(tasty["Chicken Curry"]);
//tasty["Chicken Curry"] = false;
//Console.WriteLine(tasty["Chicken Curry"]);

// new partsCatalog Dictionary<int, string>

//.ContainsKey()

//.ContainsValue()

//.Remove()