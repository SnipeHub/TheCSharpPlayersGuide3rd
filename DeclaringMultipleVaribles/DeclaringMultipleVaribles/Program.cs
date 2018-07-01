using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringMultipleVaribles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; // here we state all varibles are integers
            a = b = c = 10; // Here we state that all variables now all equal 10 :-) 
            /* Usually we state variables individually since most of the time you need multiple variables of different values, but if you needed to assign
            the same value to many, this is how you would do it. */

            Console.WriteLine("a:" + a + " b:" + b + " c:" + c);
        }
    }
}
