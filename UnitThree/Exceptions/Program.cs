// try-catch blocks
double subtotal = 0.0;

////topOfTryCatchBlocks:
//try
//{
//    Console.WriteLine("Enter subtotal: ");
//    subtotal = Double.Parse(Console.ReadLine());
//}
//catch (Exception e) //can have multiple catch blocks
//{
//    Console.WriteLine("Error! Invalid input.");
//    Console.WriteLine(e);
////    goto topOfTryCatchBlocks;
//}
//finally
//{
//    Console.WriteLine("Finally block is executed.");
//}

//Console.WriteLine("program has ended");


//while (true)
//{
//    try
//    {
//        Console.WriteLine("Enter a double");
//        double nber = double.Parse(Console.ReadLine());
//        break;
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e);
//        continue;
//    }
//}


throw new Exception("Input must be less than zero");