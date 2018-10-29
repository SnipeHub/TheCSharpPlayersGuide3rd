using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    internal class Program  // In general you should make everything as restricted (private over internal, and internal over
                   // public) as possible while still allowing things to get done.
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "J.K. Rowling");

            // Changed my mind. Let's use the full name.
            book.SetTitle("Harry Potter and the Half-Blood Prince.");

            // Now I forgot. What was the title again?
            Console.WriteLine("This is taken from the Book class and printed to screen!");
            Console.WriteLine(book.GetTitle());
        }
    }
}
