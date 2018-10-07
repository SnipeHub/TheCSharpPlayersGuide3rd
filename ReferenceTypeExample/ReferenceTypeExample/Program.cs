using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeExample // chapter 16
{
    class Program
    {
        static void Main(string[] args)
        {
            // string type is a reference type, the actual "Hello!" text will always be stored in the heap,
            // and the message variable will simply contain a reference to that text.
            // As a local variable or parameter, the message variable will be stored on the stack somewhere, 
            // and contain a reference to that actual text on the heap.
            string message = "Hello!";

            Console.WriteLine(message);

            ReferenceVariables();
        }

        static void ReferenceVariables()
        {
            // An array of strings, both of which are reference types.
            string[] messages = new string[3] { "Hello", "World", "!" };

            // if we were to do our array with numbers, they will exist in the variable and not be pointed from elsewhere.
            int[] numbers = new int[3] { 2, 3, 4 };
        }
    }
}
