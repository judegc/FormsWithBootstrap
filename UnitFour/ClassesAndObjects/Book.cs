using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Book
    {
        //properties
        public string Title;
        public Author Author;
        public int Isbn;
        public string Genre;

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