using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingMultipleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int getMultiply = Multiply(100, 20);
            Console.WriteLine($"The answer is: {getMultiply}");
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
