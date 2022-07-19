Dictionary<string, decimal> Menu = new Dictionary<string, decimal>()
{
	{ "apple", 0.99m },
	{ "banana", 0.59m },
	{ "cauliflower", 1.59m },
	{ "dragonfruit", 2.19m },
	{ "elderberry", 1.79m },
	{ "figs", 2.09m },
	{ "grapefruit", 1.99m },
	{ "honeydew", 3.49m }
};

List<string> Order = new List<string>();

bool done = false;

while (!done)
{

	bool itemfound = false;

	do
	{
		Console.WriteLine("Welcome to Chirpus Market!");
		Console.WriteLine();
		Console.WriteLine("Item            Price");
		Console.WriteLine("=====================");
		foreach (var menuitem in Menu)
		{
			Console.WriteLine(String.Format("{0,-15} ${1,-15}", menuitem.Key, menuitem.Value));
		}

		Console.WriteLine();
		Console.Write("What item would you like to order? ");
		string item = Console.ReadLine();
		if (Menu.ContainsKey(item))
		{
			itemfound = true;
			Order.Add(item);
		}
		else
		{
			Console.WriteLine("Sorry, we don't have those. Please try again.");
		}
	}
	while (itemfound == false);

	Console.Write("Would you like to order anything else? (y/n)? ");
	string entry = Console.ReadLine();
	if (entry == "n" || entry == "N")
	{
		done = true;
	}

}

Console.WriteLine();
Console.WriteLine("Thanks for your order!");
Console.WriteLine("Here's what you got:");
decimal sum = 0;
foreach (string item in Order)
{
	Console.WriteLine(String.Format("{0,-15} ${1,-15}", item, Menu[item]));
	sum += Menu[item];
}
Console.WriteLine("=====================");
Console.WriteLine("{0, -15} ${1, -15}", "TOTAL", sum);