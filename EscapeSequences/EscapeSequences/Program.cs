using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"");
            Console.WriteLine("\ttabbed \tagain"); // Tab character

            Console.WriteLine("Text\nmore\nthan\none\nline.");

            // To print out a \, you will need to use two \\ backslashes
            Console.WriteLine("C:\\Users\\RB\\Desktop\\MyFile.txt");
            // instead of \\, you can use @ symbol before the text. Called a verbatim string literal.
            Console.WriteLine(@"C:\Users\MC\Desktop\stuff.txt");
        }
    }
}
