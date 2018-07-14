using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundAssignmentOperators // end of chp 7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            a += 3;     // This is the same as a = a + 3;

            // other examples

            int b = 7;
            b -= 3;     // This is the same as b = b - 3; At this point b would be 4.
            b *= 5;     // This is the same as b = b * 5; At this point b would be 20.
            b /= 4;     // This is the same as b = b / 4; At this point b would be 5.
            b %= 2;     // This is the same as b = b % 2; At this point b would be 1.
        }
    }
}
