using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine(Fibonacci(index));
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Returns a number from the Fibonacci sequence, starting at 1.
        /// Note that this implementation is not very optimized, and can
        /// take a long timer if you're looking up large numbers.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static ulong Fibonacci(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            if (number == 2)
            {
                return 1;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
