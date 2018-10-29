using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    internal class Book
    {
        // When creating variables in a class, you can't use var, you must specify the type. These are known as Instance Variables.
        // these instance variables can be accessed by any constructor
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        // creating our constructor. They look similar to a method, the difference is that the constructor must share the same name as the class, a normal method is forbidden.
        // This is, in fact, the way that the C# compiler distinguishes the two.
        // The second difference is that constructors do not (and cannot) specify a return type. Not even void. By contrast, methods are required to specify a return type.
        public Book(string title, string author) // Making this public, allows it to be accessed from outside of the class. Private would make it reachable from inside the class.
        {
            this.title = title;
            this.author = author;
        }
        // A good way to name your variables so you don't get confused is to name your class level instance variables with either a 'm_' or just a plain '_' underscore

        // Multiple constructors. Adding a constructor that allows the user to additionally specify the pages and word count.
        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}
