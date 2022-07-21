using ClassesAndObjects;

Author authorOne = new Author()
{
    FirstName = "Aldous",
    LastName = "Huxley",
    Age = 55,
    Bio = "A. Huxley grew up in......"
};

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

List<Book> bookList = new List<Book>() { bookOne, bookTwo, bookThree };

//foreach(Book book in bookList)
//{
//    Console.WriteLine(book.Title + " by " + book.Author.FirstName + " " + book.Author.LastName);
//}

foreach(Book book in bookList)
{
    book.printBookDetails();
}
