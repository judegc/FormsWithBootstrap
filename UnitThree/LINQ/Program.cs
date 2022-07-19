List<int> intList = new List<int>() { 99, 33, 44, 1, 120, 130, 99999999 };
List<string> wordList = new List<string>()
{
    "banana",
    "computer",
    "aardvark",
    "zebra",
    "computer",
    "clouds"
};

List<int> numsLessThan100 = intList.Where(x => x < 100).ToList();
List<string> computerList = wordList.Where(word => word == "computer").ToList();

List<int> orderedNums = intList.OrderBy(x => x).ToList();
List<string> orderedWords = wordList.OrderByDescending(x => x).ToList();

List<int> orderedAndFilteredNums = intList.Where(x => x < 100).OrderBy(x => x).ToList();


//foreach (int num in orderedAndFilteredNums)
//{
//    Console.WriteLine(num);
//}

//foreach (string s in orderedWords)
//{
//    Console.WriteLine(s);
//}

Console.WriteLine(intList.Max());
Console.WriteLine(intList.Min());
Console.WriteLine(intList.Sum());
Console.WriteLine(intList.Average());
Console.WriteLine(intList.Any(x => x > 1000));