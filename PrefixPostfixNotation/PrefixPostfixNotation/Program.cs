using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixPostfixNotation
{
    class Program
    {
        static void Main(string[] args)
        { // With postfix notation (a++;) the original value of a is returned. With prefix
          // notation(++a;) the new, incremented value is returned.

            int a = 3;
            int b = ++a; // Both 'a' and 'b' will now be 4.
            Console.WriteLine($"Variable a is: {a}, and b is: {b}");

            int c = 3;
            int d = c++; // The original value of 3 is assigned to 'd', while 'c' is now 4.
            Console.WriteLine($"variable c is: {c}, d is: {d}");
            // a++ means, “give me the value in a, then increment a,” while ++a means, “increment a first, then give me
            // the resulting value.”

            // To help mitigate confusion it is better to split the logic across two lines:
            int e = 3;
            e++;
            int f = e;

            int g = 3;
            int h = g; // g and h both store 3
            g++; // but only g becomes 4, leaving h, which still contains 3
        }
    }
}
