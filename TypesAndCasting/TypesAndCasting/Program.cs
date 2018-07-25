using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4049;
            long b = 284404039;
            long sum = a + b; // when the int is cast into the long, it is fine, there will be no data loss

            Console.WriteLine(sum); // this is called a widening conversion

            int c = 7;
            float d = 2; // this converts the integer value 2 to the floating point value 2.0
                         // The value in `a` below will get implicitly cast to a float to do this division because `b` is a float.
                         // This results in floating point division, rather than integer division.
            float result = a / b;
            Console.WriteLine(result);

            // to turn a wider type intoa narrower type, this is called an explicit cast.
            long e = 3;
            int f = (int)a;
            int resultTwo = Convert.ToInt32(e + f); // if the wider type can't go into the narrower type, yuou need to to the usual Convert.ToWhatever() methods.
            Console.WriteLine(resultTwo);

            // Casting is considered an operator like addition or multiplication. Casting has a higher precedence than the arithmetic operators like addition and multiplication.
            float resultThree = (float)(3.0 / 5.0) + 1;
            Console.WriteLine(resultThree);
        }
    }
}
