using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Book
    {
        //constructor(s)
        public Book(string argTitle, Author argAuthor, int argIsbn, string argGenre)
        {
            Title = argTitle;
            Author = argAuthor;
            Isbn = argIsbn;
            Genre = argGenre;
        }

        public Book() { } //empty constructor

        //properties
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Isbn { get; set; }
        public string Genre { get; set; }

        //methods
        /// <summary>
        /// Prints all details of the book to the console.
        /// </summary>
        public void printBookDetails()
        {
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Title:", Title));
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Author:", Author.FirstName + " " + Author.LastName));
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "ISBN:", Isbn));
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Genre:", Genre));
        }
    }
}