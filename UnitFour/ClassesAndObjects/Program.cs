using ClassesAndObjects;
using ClassesAndObjects.Enums;

Author authorOne = new Author("Aldous", "Huxley", -8765, "xyz");

//Console.WriteLine(authorOne.Age);

var bookOne = new Book()
{
    Title = "Brave New World",
    Author = authorOne,
    Isbn = 1234567890,
    Genre = BookGenre.Fiction
};

Book bookTwo = new Book()
{
    Title = "Guns, Germs, Steel",
    Author = authorOne,
    Isbn = 0987654321,
    Genre = BookGenre.NonFiction
};

Book bookThree = new Book();
bookThree.Title = "Oliver Twist";
bookThree.Author = authorOne;
bookThree.Isbn = 1122334455;
bookThree.Genre = BookGenre.Fiction;

Book bookFour = new Book("Atomic Habits", authorOne, 2147483647, BookGenre.SelfHelp);

List<Book> bookList = new List<Book>() { bookOne, bookTwo, bookThree, bookFour };

//foreach (Book book in bookList)
//{
//    Console.WriteLine(book.Title + " by " + book.Author.FirstName + " " + book.Author.LastName);
//}

//foreach (Book book in bookList)
//{
//    book.PrintBookDetails();
//}

//bookOne.PrintBookDetails();

//LINQ .Select() example
var bookTitles = bookList.Select(b => b.Title).ToList();
//bookTitles.ForEach(x => Console.WriteLine(x));

//example of type-casting enums 
//Console.WriteLine((int)bookOne.Genre);



Helper.PrintTwoStrings("Aaron", "Krumsieg");
Helper.PrintTwoStrings(bookOne.Title, bookOne.Genre.ToString());
















//STATIC VS NONSTATIC
//string s = "Hello World";
//Console.WriteLine(s.Contains("o")); //non-static method bc it is called on an instance/object
//Console.WriteLine(String.Concat(s, s)); //static method bc it is called on the class itself
//Console.WriteLine(); //this is a static method on a static class