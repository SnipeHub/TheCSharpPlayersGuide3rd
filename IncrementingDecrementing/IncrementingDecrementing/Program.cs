using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingDecrementing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a = a + 1; // Normal addition operator, and then assign it to the variable.
            Console.WriteLine($"Incrementing by 1 into the variable a = 3, is: {a}");

            int b = 3;
            b = b += 1; // The compound addition/assignment operator. -+ is when subtracting
            Console.WriteLine($"\nIncrementing with += operator: {b}");

            // and a third way
            int c = 3;
            c++; // can also subtract with '--'
            Console.WriteLine($"\nIncrementing with c++: {c}");
        }
    }
}
