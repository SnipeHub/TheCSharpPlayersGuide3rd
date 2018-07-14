using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            // This isn't a real formula for anything. I'm just making it up for an example.

            double a = 3.2;
            double b = -4.3;
            double c = 42;
            double d = -91;
            double e = 4.343;

            double result = (((a + b) * (c - 4)) + d) * e; // look carfefully and you can see the order.

            Console.WriteLine("The result is: " + result);

            // Operators also have a concept called associativity, which indicate how multiple operations of the same precedence are grouped together.

            int x = 5 - 3 - 1; // what does x equal to?
            Console.WriteLine(x); // 1, because we go lewft to right, it will be 5 - 3, which 2, then 2 - 1 = 1
        }
    }
}
