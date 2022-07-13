string[] titles; //declare
titles = new string[3]; //instantiating an empty array with 3 elements

titles[0] = "What About Bob?";
titles[2] = "Groundhog Day";

//Console.WriteLine(titles[0]);
//Console.WriteLine(titles[1]); //value is null so it prints an empty line
//Console.WriteLine(titles[2]);


int index = 3;
int[] intArray = { 111, 88, 99, 77}; //declare, instantiate, and assign values
//Console.WriteLine(intArray[index]);
intArray[index] = 999;
//Console.WriteLine(intArray[index]);

intArray = new int[4] { 22, 99, 44, 11 }; //to reassign all values to an array variable, we need to create a new array


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

//for (int i = 0; i < intArray.Length; i++)
//{
//    Console.WriteLine(intArray[i]);
//    intArray[i]++;
//    Console.WriteLine(intArray[i]);
//}

//int[] intArrayTwo = intArray;
//int[] intArrayThree = new int[4];
//intArray.CopyTo(intArrayThree, 0);
//Array.Sort(intArray);

//foreach (int i in intArray)
//{
//    Console.WriteLine("intArray " + i);
//}

//foreach (int i in intArrayTwo)
//{
//    Console.WriteLine("intArrayTwo " + i);
//}

//foreach (int i in intArrayThree)
//{
//    Console.WriteLine("intArrayThree " + i);
//}


//2D Arrays
//int[,] twoDArray = new int[2, 3]
//{
//    { 11, 12, 13 },
//    { 21, 22, 23 },
//};


//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(twoDArray[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//char[,] ticTacToeBoard = new char[3, 3]
//{
//    { '_', '_', '_' },
//    { '_', '_', '_' },
//    { '_', '_', '_' },
//};

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(ticTacToeBoard[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//ticTacToeBoard[0, 0] = 'X';
//ticTacToeBoard[1, 1] = 'O';
//ticTacToeBoard[2, 0] = 'X';

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(ticTacToeBoard[i, j] + " ");
//    }
//    Console.WriteLine();
//}