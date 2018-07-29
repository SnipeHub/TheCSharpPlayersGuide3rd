using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity
{
    class Program
    {
        static void Main(string[] args)
        {
            // There are a few special values that are worth discussing. Let’s start off by looking at infinity. Both the
            // double and the float type define special values to represent positive and negative infinity(+∞ and -∞).In
            // the math world, doing stuff with infinity often results in some rather unintuitive situations. For example, ∞
            // +1 is still ∞, as is subtracting 1: ∞ -1 = ∞

            double a = double.PositiveInfinity;
            float b = float.PositiveInfinity;

            Console.WriteLine($"{a} {b}");
        }
    }
}
