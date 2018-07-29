using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowUnderflow
{
    class Program
    {
        static void Main(string[] args)
        { // A short can have a maximum value of up to 32767. So what if we do this?
            short a = 30000;
            short b = 30000;
            short sum = (short)(a + b); // The sum will be too big to fit into a short. What happens?

            Console.WriteLine($"The sum will not fit, therefore going into negative causing an overflow : {sum}");

            // Another similar condition called underflow that can occur sometimes with floating point types.Imagine
            // you have a very large floating point number.Something like 1,000,000,000,000.A float can store that
            // number. Now let’s say you have a very small number, like 0.00000001.You can store that as a float as
            // well. However, if you add the two together, a float cannot store the result: 1,000,000,000,000.00000001.
        }
    }
}
