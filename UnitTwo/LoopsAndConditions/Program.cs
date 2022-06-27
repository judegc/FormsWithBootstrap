// **** SELECTION STATEMENTS ****
// if else statements
//Console.WriteLine("How old is your dog? Enter a whole number.");
//string age = Console.ReadLine();
//int ageOfDog = int.Parse(age);
//if (ageOfDog <= 1)
//{
//    Console.WriteLine("You have a puppy.");
//}
//else if (ageOfDog <= 3)
//{
//    Console.WriteLine("You have a young dog.");
//}
//else if (ageOfDog <= 7)
//{
//    Console.WriteLine("You have a middle aged dog.");
//}
//else
//{
//    Console.WriteLine("You have an old dog.");
//}

//switch statement
//Console.WriteLine("How old is your dog? Enter a whole number.");
//string age = Console.ReadLine();
//int ageOfDog = int.Parse(age);
//switch (ageOfDog)
//{
//    case 0:
//        Console.WriteLine("Your dog is 0 years old");
//        break;
//    case 1:
//        Console.WriteLine("You dog is 1 years old");
//        break;
//    default:
//        break; //do nothing if dog is not 0 or 1 years old
//}

//ternary statement
//Console.WriteLine("Do you live in Michigan? y/n");
//string input = Console.ReadLine();
//string message = input == "y" ? "Go Blue!" : "Go Hawkeyes!";
//Console.WriteLine(message);


//****LOOPS****
//while loop
//int mpg = 26;
//int gallonsInTank = 1;
//int distanceTraveled = 0;
//Console.WriteLine("There are " + gallonsInTank + " gallons in the tank.");
//Console.WriteLine("You have traveled " + distanceTraveled + " miles.");
//while (gallonsInTank > 0)
//{
//    gallonsInTank--; //gallonsInTank = gallonsInTank - 1;
//    distanceTraveled += mpg; // distanceTraveled = distanceTraveled + mpg
//}
//Console.WriteLine("There are " + gallonsInTank + " gallons in the tank.");
//Console.WriteLine("You have traveled " + distanceTraveled + " miles.");

//do while loop
int channelsWatched = 0;
int boredomLevel = 5;
do
{
    channelsWatched++;
    Console.WriteLine(channelsWatched);
    boredomLevel--;
}
while (boredomLevel > 0);