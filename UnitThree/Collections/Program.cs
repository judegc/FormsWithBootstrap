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
//for (int i = 0; i < students.Count(); i++)
//{
//    Console.WriteLine(students[i]);
//}

//.IndexOf()
//int index = students.IndexOf("Jacob");
//Console.WriteLine(index);

//.LastIndexOf()
//Console.WriteLine(students.LastIndexOf("Jacob"));

//.Sort()
//students.Sort();
//for (int i = 0; i < students.Count(); i++)
//{
//    Console.WriteLine(students[i]);
//}

//.Reverse()
//students.Reverse();
//for (int i = 0; i < students.Count(); i++)
//{
//    Console.WriteLine(students[i]);
//}

//.Clear()
//students.Clear();
//for (int i = 0; i < students.Count(); i++)
//{
//    Console.WriteLine(students[i]);
//}






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
Dictionary<int, string> partsCatalog = new Dictionary<int, string>()
{
    { 1001, "hubcap" },
    { 1002, "lugnuts" },
    { 1003, "oil filter" }
};

//.ContainsKey()
//Console.WriteLine(partsCatalog.ContainsKey(99));
//Console.WriteLine(partsCatalog.ContainsKey(1002));

//.ContainsValue()
//Console.WriteLine(partsCatalog.ContainsValue("steering wheel"));
//Console.WriteLine(partsCatalog.ContainsValue("lugnuts"));

//.ElementAt()
//KeyValuePair<int, string> firstElement = partsCatalog.ElementAt(0);
//Console.WriteLine(firstElement);

//.Remove()
//partsCatalog.Remove(1002);
//foreach (KeyValuePair<int, string> kvp in partsCatalog)
//{
//    Console.WriteLine(kvp);
//}



//STACK (Last-in-first-out)
Stack<int> numberStack = new Stack<int>();
numberStack.Push(1); //.Push() adds elements one by one
numberStack.Push(2);
numberStack.Push(3);
numberStack.Push(4);
numberStack.Push(5);

//foreach (int i in numberStack)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(numberStack.Pop()); //.Pop() removes and returns the top element in the stack

//Console.WriteLine(numberStack.Peek()); //.Peek() returns but DOES NOT REMOVE the top element

//Console.WriteLine(numberStack.Contains(4));

//Console.WriteLine(numberStack.Count());


//QUEUE (First-in-first-out)
Queue<string> names = new Queue<string>();
names.Enqueue("Tolu");
names.Enqueue("Jude");
names.Enqueue("Kevin");
names.Enqueue("Collin");

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

Console.WriteLine(names.Dequeue()); //.Dequeue() removes and returns the first element in the queue

Console.WriteLine(names.Peek());

Console.WriteLine(names.Contains("Jude"));

Console.WriteLine(names.Count);
