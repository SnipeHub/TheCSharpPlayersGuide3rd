using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation // New feature added in C# 6.0 chp 8 complete
{
    class Program
    {
        static void Main(string[] args)
        {
            // The normal way of concatenating the strings and code together with a "+".
            double volume = 21;
            double height = 4;

            Console.WriteLine("The cylinder's volume is: " + volume + " cubic units.");

            // the C# 6.0 feature called String Interpolation. Me likey. Makes it more readable, just need to make sure to place the $ sign.
            Console.WriteLine($"\nThe cylinder's volume is: {volume + height} cubic units. The height is {height - volume} metres");
            // The curly braces can contain any valid C# expression. It's not limited to just a single variable.
            // That means you can do things like perform some simple math, or call a method, etc.
        }
    }
}
