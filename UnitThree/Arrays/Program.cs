string[] titles; //declare
titles = new string[3]; //instantiating an empty array with 3 elements

titles[0] = "What About Bob?";
titles[2] = "Groundhog Day";

//Console.WriteLine(titles[0]);
//Console.WriteLine(titles[1]); //value is null so it prints an empty line
//Console.WriteLine(titles[2]);


int index = 3;
int[] intArray = { 77, 88, 99, 111 }; //declare, instantiate, and assign values
//Console.WriteLine(intArray[index]);
intArray[index] = 999;
//Console.WriteLine(intArray[index]);

intArray = new int[4] { 22, 33, 44, 55 }; //to reassign all values to an array variable, we need to create a new array


//LOOPING THROUGH ARRAYS
//for (int i = 0; i < intArray.Length; i++)
//{
//    Console.WriteLine(intArray[i]);
//}


decimal [] prices = { 2.50m, 9.99m, 5.00m };
decimal sum = 0;
//for (int i = 0; i < prices.Length; i++)
//{
//    sum += prices[i];
//}
//foreach (decimal price in prices)
//{
//    sum += price;
//}
//Console.WriteLine("The average price is: " + sum / prices.Length);


//foreach (int num in intArray)
//{
//    Console.WriteLine(num);
//}

for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine(intArray[i]);
    intArray[i]++;
    Console.WriteLine(intArray[i]);
}