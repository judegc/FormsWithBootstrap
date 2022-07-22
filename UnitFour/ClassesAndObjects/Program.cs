using ClassesAndObjects;

Author authorOne = new Author("Aldous", "Huxley", -8765, "xyz");

Console.WriteLine(authorOne.Age);

Book bookOne = new Book()
{
    Title = "Brave New World",
    Author = authorOne,
    Isbn = 1234567890,
    Genre = "Fiction"
};

Book bookTwo = new Book()
{
    Title = "Guns, Germs, Steel",
    Author = authorOne,
    Isbn = 0987654321,
    Genre = "History"
};

Book bookThree = new Book();
bookThree.Title = "Oliver Twist";
bookThree.Author = authorOne;
bookThree.Isbn = 1122334455;
bookThree.Genre = "Historical Fiction";

Book bookFour = new Book("Atomic Habits", authorOne, 2147483647, "Self-help");

List<Book> bookList = new List<Book>() { bookOne, bookTwo, bookThree, bookFour };

foreach (Book book in bookList)
{
    Console.WriteLine(book.Title + " by " + book.Author.FirstName + " " + book.Author.LastName);
}

//foreach (Book book in bookList)
//{
//    book.printBookDetails();
//}
